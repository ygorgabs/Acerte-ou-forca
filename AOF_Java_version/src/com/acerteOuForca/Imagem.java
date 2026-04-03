package com.acerteOuForca;

import java.io.IOException;
import java.io.InputStream;

public class Imagem {
    public static byte[] toByteArray(String path)throws IOException, NullPointerException{
        byte[] imageBytes;
        try(InputStream stream = Imagem.class.getResourceAsStream(path)){
            if(stream == null){
                throw new NullPointerException("Imagem não localizada no caminho: " + path);
            }

            imageBytes = stream.readAllBytes();
        }
        return imageBytes;
    }
}
