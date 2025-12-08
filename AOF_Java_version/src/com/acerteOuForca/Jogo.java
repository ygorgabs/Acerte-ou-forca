package com.acerteOuForca;

import javax.swing.*;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import java.util.Random;

public class Jogo extends JFrame {
    private JPanel panelJogo;
    private JTextField txtLetra;
    private JButton btnVerificar;
    private JButton btnPalavra;
    private JButton btnTema;
    private JLabel lblTema;
    private JLabel lblVItorias;
    private JLabel lblPalavra;
    private JLabel lblForca;
    private JLabel lblLetrasUsadas;

    private Compartilha compartilha = new Compartilha();
    private String palavraSelecionada, palavraEncriptada;
    private String[] palavras;
    private Integer contarAcertos = 0, contarErros = 0;
    private Boolean mudarTema = false;

    public Jogo() {
        ConfigPanel.configurar(this,panelJogo,600,380,"Acerte ou Forca");
        lblTema.setText("Tema: "+compartilha.getTema().name());
        lblVItorias.setText("Vitorias: "+compartilha.getVitorias());
        palavras = compartilha.getPalavras();
        sortearPalavra();


        btnVerificar.addActionListener(new ActionListener() {
            @Override
            public void actionPerformed(ActionEvent actionEvent) {
                analisaLetraInserida();
            }
        });
    }

    private void sortearPalavra() {
        if(palavras == null ||  palavras.length == 0) return;

        Random random = new Random();
        int posicao = random.nextInt(palavras.length);

        palavraSelecionada = palavras[posicao];
        palavraEncriptada = "";

        for(String letra : palavras){
            palavraEncriptada += "*";
        }

        lblPalavra.setText(palavraEncriptada);
    }

    private void verificarErro(){
        String boneco = switch (contarErros){
            case 0 -> "<html>\n" +
                    "  <p style=\"font-size:50px; text-align:center\">O</p>\n" +
                    "  <p style=\"font-size:60px;text-align:center\">   </p>\n" +
                    "  <p style=\"font-size:70px; text-align:center\">   </p>\n" +
                    "</html>";
            case 1 -> "<html>\n" +
                    "  <p style=\"font-size:50px; text-align:center\">O</p>\n" +
                    "  <p style=\"font-size:60px;text-align:center\">/  </p>\n" +
                    "  <p style=\"font-size:70px; text-align:center\">   </p>\n" +
                    "</html>";
            case 2 -> "<html>\n" +
                    "  <p style=\"font-size:50px; text-align:center\">O</p>\n" +
                    "  <p style=\"font-size:60px; text-align:center\">/| </p>\n" +
                    "  <p style=\"font-size:70px; text-align:center\">   </p>\n" +
                    "</html>";
            case 3 -> "<html>\n" +
                    "  <p style=\"font-size:50px; text-align:center\">O</p>\n" +
                    "  <p style=\"font-size:60px; text-align:center\">/|\\</p>\n" +
                    "  <p style=\"font-size:70px; text-align:center\">   </p>\n" +
                    "</html>";
            case 4 -> "<html>\n" +
                    "  <p style=\"font-size:50px; text-align:center\">O</p>\n" +
                    "  <p style=\"font-size:60px; text-align:center\">/|\\</p>\n" +
                    "  <p style=\"font-size:70px; text-align:center\">/  </p>\n" +
                    "</html>";
            case 5 -> "<html>\n" +
                    "  <p style=\"font-size:50px; text-align:center\">O</p>\n" +
                    "  <p style=\"font-size:60px; text-align:center\">/|\\</p>\n" +
                    "  <p style=\"font-size:70px; text-align:center\">/ \\</p>\n" +
                    "</html>";
            default -> "";
        };

        contarErros++;
        lblForca.setText(boneco);
        txtLetra.setText("");

        if(contarErros == 6){
            JOptionPane.showMessageDialog(null,"A palavra selecionada era: " + palavraSelecionada + ". Tente novamente!");
            btnVerificar.setEnabled(false);
        }
    }

    private void verificarAcerto(char letra){
        char[] verificaPalavra = palavraEncriptada.toCharArray();

        for(int i = 0; i < verificaPalavra.length; i++){
            if(palavraSelecionada.charAt(i) == letra){
                contarAcertos++;
                verificaPalavra[i] = letra;
            }
        }

        palavraEncriptada = new  String(verificaPalavra);
        lblPalavra.setText(palavraEncriptada);
        txtLetra.setText("");

        if(contarAcertos == palavraSelecionada.length()){
            btnVerificar.setEnabled(false);
            compartilha.setVitorias();
        }
    }

    private void analisaLetraInserida(){
        if(txtLetra.getText().isEmpty()){
            JOptionPane.showMessageDialog(null, "Necessário digitar uma letra para jogar.");
            return;
        }

        char letra = txtLetra.getText().toUpperCase().charAt(0);

        if((int)letra < 65 || (int)letra > 90){
            JOptionPane.showMessageDialog(null, "Permitido somente letras. Por favor, digite um valor de A-Z");
            return;
        }

        lblLetrasUsadas.setText(lblLetrasUsadas.getText() + letra + " ");

        if(palavraSelecionada.contains(letra+"")){
            verificarErro();
            return;
        }
        verificarAcerto(letra);
    }
}
