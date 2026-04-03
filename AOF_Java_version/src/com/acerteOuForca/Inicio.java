package com.acerteOuForca;

import javax.swing.*;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import java.io.IOException;
import java.io.InputStream;

public class Inicio extends JFrame {
    private JPanel panelInicio;
    private JButton btnHello;
    private JLabel lblLogo;

    public Inicio() {
        ConfigPanel.configurar(this, panelInicio, 600, 350, "Bem-vindo");

        try {
            byte[] logoBytes = Imagem.toByteArray("/images/logo.png");
            lblLogo.setIcon(new ImageIcon(logoBytes));

        } catch (IOException e) {
            JOptionPane.showMessageDialog(null, e.getMessage(), "Erro", JOptionPane.ERROR_MESSAGE);
        }

        btnHello.addActionListener(new ActionListener() {
            @Override
            public void actionPerformed(ActionEvent actionEvent) {
                Tema panelTema = new Tema();
                panelTema.setVisible(true);
                dispose();
            }
        });

        btnHello.setFocusPainted(false);
    }

    public static void main(String[] args) {
        new Inicio().setVisible(true);
    }
}
