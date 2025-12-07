package com.acerteOuForca;

import javax.swing.*;

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

    public Jogo() {
        ConfigPanel.configurar(this,panelJogo,600,380,"Acerte ou Forca");
        lblTema.setText("Tema: "+compartilha.getTema().name());
    }
}
