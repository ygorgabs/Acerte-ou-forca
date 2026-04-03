package com.acerteOuForca;

import javax.swing.*;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStream;
import java.io.InputStreamReader;
import java.util.ArrayList;

public class Tema extends JFrame {
    private JPanel panelTema;
    private JButton btnAnimais;
    private JButton btnEletronicos;
    private JButton btnPapelaria;
    protected Compartilha compartilha = new Compartilha();

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

        btnAnimais.setFocusPainted(false);
    }

    protected void obterPalavras(Compartilha.Tema tema) {
        String arquivo = "/temas/" + tema.name().toLowerCase() + ".txt";
        ArrayList<String> palavras = new ArrayList<>();

        try (InputStream stream = getClass().getResourceAsStream(arquivo)) {

            if (stream == null) {
                JOptionPane.showMessageDialog(null, "Arquivo Não encontrado", "Erro", JOptionPane.ERROR_MESSAGE);
                return;
            }

            try (BufferedReader lerArquivo = new BufferedReader(new InputStreamReader(stream))) {
                String palavra;
                while ((palavra = lerArquivo.readLine()) != null) {
                    palavras.add(palavra);
                }
            }
        } catch (IOException e) {
            JOptionPane.showMessageDialog(null, "Erro ao ler arquivo: " + e.getMessage(), "Erro", JOptionPane.ERROR_MESSAGE);
            return;
        }
        compartilha.setTema(tema);
        compartilha.setPalavras(palavras);
    }

    protected void iniciarJogo() {
        Jogo jogo = new Jogo();
        jogo.setVisible(true);
        dispose();
    }
}
