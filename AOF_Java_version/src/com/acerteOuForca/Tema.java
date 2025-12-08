package com.acerteOuForca;

import javax.swing.*;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import java.io.*;

public class Tema extends JFrame {
    private JPanel panelTema;
    private JButton btnAnimais;
    private JButton btnEletronicos;
    private JButton btnPapelaria;
    protected Compartilha com = new Compartilha();

    public Tema() {
        ConfigPanel.configurar(this, panelTema, 600, 350, "Selecione um Tema");

        btnAnimais.addActionListener(new ActionListener() {
            @Override
            public void actionPerformed(ActionEvent actionEvent) {
                obterPalavras(Compartilha.Tema.Animais);
                iniciarJogo();
            }
        });
        btnEletronicos.addActionListener(new ActionListener() {
            @Override
            public void actionPerformed(ActionEvent actionEvent) {
                obterPalavras(Compartilha.Tema.Eletronicos);
                iniciarJogo();
            }
        });
        btnPapelaria.addActionListener(new ActionListener() {
            @Override
            public void actionPerformed(ActionEvent actionEvent) {
                obterPalavras(Compartilha.Tema.Papelaria);
                iniciarJogo();
            }
        });
    }

    protected void obterPalavras(Compartilha.Tema tema) {
        String arquivo = "";
        String[] palavras = new String[10];

        switch (tema) {
            case Animais:
                arquivo = "/animais.txt";
                break;
            case Papelaria:
                arquivo = "/papelaria.txt";
                break;
            case Eletronicos:
                arquivo = "/eletronicos.txt";
                break;
        }
        try(InputStream stream = getClass().getResourceAsStream(arquivo)){

            if(stream == null){
                JOptionPane.showMessageDialog(null,"Arquivo Não encontrado");
                return;
            }

            InputStreamReader arq = new InputStreamReader(stream);
            BufferedReader lerArq = new BufferedReader(arq);

            String linha1 = lerArq.readLine();

            if(linha1 != null){
                palavras[0] = linha1;

                for (int i = 1; i < palavras.length; i++) {
                    palavras[i] = lerArq.readLine();
                }
            }
        }catch(IOException e){
            JOptionPane.showMessageDialog(null,"Erro ao ler arquivo: " + e.getMessage());
        }

        com.setTema(tema);
        com.setPalavras(palavras);
    }

    protected void iniciarJogo() {
        Jogo jogo = new Jogo();
        jogo.setVisible(true);
        dispose();
    }
}
