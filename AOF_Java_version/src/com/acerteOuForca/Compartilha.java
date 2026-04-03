package com.acerteOuForca;

import java.util.ArrayList;

public class Compartilha {

    public enum Tema{
        Animais,
        Eletronicos,
        Papelaria
    }
    private static ArrayList<String> palavras;
    private static int vitorias = 0;
    private static Tema tema;

    public ArrayList<String> getPalavras() {
        return palavras;
    }

    public void setPalavras(ArrayList<String> palavras) {
        Compartilha.palavras = palavras;
    }

    public int getVitorias() {
        return vitorias;
    }

    public void setVitorias() {
        Compartilha.vitorias++;
    }

    public Tema getTema() {
        return tema;
    }

    public void setTema(Tema tema) {
        Compartilha.tema = tema;
    }
}
