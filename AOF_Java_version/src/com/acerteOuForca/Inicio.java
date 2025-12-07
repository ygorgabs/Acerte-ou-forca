package com.acerteOuForca;

import javax.swing.*;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;

public class Inicio extends JFrame {
    private JPanel panelIncio;
    private JButton btnHello;

    public Inicio() {
        ConfigPanel.configurar(this, panelIncio,600, 350, "Início");
        btnHello.addActionListener(new ActionListener() {
            @Override
            public void actionPerformed(ActionEvent actionEvent) {
                Tema panelTema = new Tema();
                panelTema.setVisible(true);
                dispose();
            }
        });
    }

    public static void main(String[] args) {
        new Inicio().setVisible(true);

    }
}
