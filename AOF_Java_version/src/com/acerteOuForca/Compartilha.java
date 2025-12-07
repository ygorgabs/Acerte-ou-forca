package com.acerteOuForca;

public class Compartilha {

    public enum Tema{
        Animais,
        Eletronicos,
        Papelaria
    }
    private static String[] palavras;
    private static int vitorias = 0;
    private static Tema tema;

    public String[] getPalavras() {
        return palavras;
    }

    public void setPalavras(String[] palavras) {
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
