package com.acerteOuForca;

import javax.swing.*;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import java.io.IOException;
import java.util.ArrayList;
import java.util.Random;

public class Jogo extends JFrame {
    private JPanel panelJogo;
    private JTextField txtLetra;
    private JButton btnVerificar;
    private JButton btnPalavra;
    private JButton btnTema;
    private JLabel lblTema;
    private JLabel lblVitorias;
    private JLabel lblPalavra;
    private JLabel lblForca;
    private JLabel lblLetrasUsadas;
    private JLabel lblCabeca, lblBracoDir, lblBracoEsq, lblTronco, lblPernaDir, lblPernaEsq;


    private Compartilha compartilha = new Compartilha();
    private String palavraSelecionada;
    private StringBuilder palavraEncriptada;
    private ArrayList<String> palavras;
    private Integer contarAcertos = 0, contarErros = 0;

    public Jogo() {
        ConfigPanel.configurar(this,panelJogo,700,500,"Acerte ou Forca");
        lblTema.setText("Tema: "+compartilha.getTema().name());
        lblVitorias.setText("Vitorias: "+compartilha.getVitorias());
        palavras = compartilha.getPalavras();
        sortearPalavra();


        btnVerificar.addActionListener(new ActionListener() {
            @Override
            public void actionPerformed(ActionEvent actionEvent) {
                analisaLetraInserida();
            }
        });
        btnPalavra.addActionListener(new ActionListener() {
            @Override
            public void actionPerformed(ActionEvent actionEvent) {
                novaPalavra();
            }
        });
        btnTema.addActionListener(new ActionListener() {
            @Override
            public void actionPerformed(ActionEvent actionEvent) {
                novoTema();
            }
        });
    }

    private void sortearPalavra() {
        if(palavras == null ||  palavras.isEmpty()) return;

        Random random = new Random();
        int posicao = random.nextInt(palavras.size());

        palavraSelecionada = palavras.get(posicao).toUpperCase();
        palavraEncriptada = new StringBuilder();

        palavraEncriptada.repeat("*",palavraSelecionada.length());

        lblPalavra.setText(palavraEncriptada.toString());
    }

    private void verificarErro(){
        contarErros++;
        try{
            byte[] logoBytes;
            switch (contarErros){
                case 1:
                        logoBytes = Imagem.toByteArray("/images/cabeca.png");
                        lblCabeca.setIcon(new ImageIcon(logoBytes));
                        break;
                case 2:
                    logoBytes = Imagem.toByteArray("/images/tronco.png");
                    lblTronco.setIcon(new ImageIcon(logoBytes));
                    break;
                case 3:
                    logoBytes = Imagem.toByteArray("/images/braco_direito.png");
                    lblBracoDir.setIcon(new ImageIcon(logoBytes));
                    break;
                case 4:
                    logoBytes = Imagem.toByteArray("/images/braco_esquerdo.png");
                    lblBracoEsq.setIcon(new ImageIcon(logoBytes));
                    break;
                case 5:
                    logoBytes = Imagem.toByteArray("/images/perna_direita.png");
                    lblPernaDir.setIcon(new ImageIcon(logoBytes));
                    break;
                case 6:
                    logoBytes = Imagem.toByteArray("/images/perna_esquerda.png");
                    lblPernaEsq.setIcon(new ImageIcon(logoBytes));
                    break;
            }

        }catch (IOException e){
            JOptionPane.showMessageDialog(null,e.getMessage(),"Erro", JOptionPane.ERROR_MESSAGE);
        }
        txtLetra.setText("");

        if(contarErros == 6){
            JOptionPane.showMessageDialog(null,"Tente novamente!","A palavra selecionada era: " + palavraSelecionada,JOptionPane.WARNING_MESSAGE);
            btnVerificar.setEnabled(false);
        }
    }

    private void verificarAcerto(char letra){

        for(int i = 0; i < palavraSelecionada.length(); i++){
            if(palavraSelecionada.charAt(i) == letra){
                contarAcertos++;
                palavraEncriptada.setCharAt(i,palavraSelecionada.charAt(i));
            }
        }

        lblPalavra.setText(palavraEncriptada.toString());
        txtLetra.setText("");

        if(contarAcertos == palavraSelecionada.length()){
            JOptionPane.showMessageDialog(null,"Parabens","Você Acertou a palavra!!!",JOptionPane.INFORMATION_MESSAGE);
            btnVerificar.setEnabled(false);
            compartilha.setVitorias();
            lblVitorias.setText("Vitórias: "+compartilha.getVitorias());
        }
    }

    private void analisaLetraInserida(){
        if(txtLetra.getText().isEmpty()){
            JOptionPane.showMessageDialog(null, "Caractere inválido!","Necessário digitar uma letra para jogar.",JOptionPane.ERROR_MESSAGE);
            return;
        }

        char letra = txtLetra.getText().toUpperCase().charAt(0);

        if((int)letra < 65 || (int)letra > 90){
            JOptionPane.showMessageDialog(null, "Permitido somente letras","Por favor, digite um valor de A-Z",JOptionPane.ERROR_MESSAGE);
            return;
        }

        lblLetrasUsadas.setText(lblLetrasUsadas.getText() + letra + " ");

        if(!palavraSelecionada.contains(String.valueOf(letra))){
            verificarErro();
            return;
        }
        verificarAcerto(letra);
    }

    private void novaPalavra(){
        lblForca.setText("");
        lblPalavra.setText("");
        lblLetrasUsadas.setText("");

        contarAcertos = 0;
        contarErros = 0;

        lblVitorias.setText("Vitórias: " + compartilha.getVitorias());
        btnVerificar.setEnabled(true);
        sortearPalavra();
    }

    private void novoTema(){
        Tema tema = new Tema();
        tema.setVisible(true);
        dispose();
    }
}
