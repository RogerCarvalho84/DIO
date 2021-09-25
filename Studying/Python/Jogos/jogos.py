import forca
import adivinhacao

def escolhe_jogo():
    print("*********************************")
    print("*******Escolha o seu jogo!*******")
    print("*********************************", end="\n\n")


    print("(1) Forca (2) Adivinhação")

    escolha = int(input("Qual jogo?"))

    if(escolha == 1):
        print("Jogando forca")
        forca.jogar()

    elif(escolha == 2):
        print("Jogando adivinhação")
        adivinhacao.jogar()

if(__name__ == "__main__"):
    escolhe_jogo()