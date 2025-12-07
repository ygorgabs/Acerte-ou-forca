package com.acerteOuForca;

import javax.swing.*;
import java.awt.*;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;

public class Tema extends JFrame {
    private JPanel panelTema;
    private JButton btnTema1;
    private JButton btnTema2;
    private JButton btnTema3;

    public Tema() {
        ConfigPanel.configurar(this, panelTema, 600, 350, "Selecione um Tema");
        btnTema1.addActionListener(new ActionListener() {
            @Override
            public void actionPerformed(ActionEvent actionEvent) {
                Jogo jogo = new Jogo();
                jogo.setVisible(true);
                dispose();
            }
        });
    }

}
