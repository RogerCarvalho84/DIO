def jogar():
    print("*********************************")
    print("** Bem vindo ao jogo da forca! **")
    print("*********************************", end="\n\n")

    palavra_secreta = "machado"
    enforcou = False
    acertou = False

    while(not enforcou and not acertou):
        chute = input("Chute uma letra...")
        chute = chute.strip()

        index = 0
        for letra in palavra_secreta:
            if(letra.upper() == chute.upper()):
                print("Encontrei a letra {} na posição {}.".format(letra, index+1))
            index += 1
        print("jogando ...")



    print("Fim do jogo!")

if(__name__ == "__main__"):
    jogar()