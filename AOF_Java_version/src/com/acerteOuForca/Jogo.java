package com.acerteOuForca;

import javax.swing.*;

public class Jogo extends JFrame {
    private JPanel panelJogo;

    public Jogo() {
        ConfigPanel.configurar(this,panelJogo,600,350,"Acerte ou Forca");
    }
}
