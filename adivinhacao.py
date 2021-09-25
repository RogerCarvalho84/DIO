import random

def jogar():
    print("*********************************")
    print("Bem vindo ao jogo de adivinhação!")
    print("*********************************", end="\n\n")

    numero_secreto = round(random.randrange(1,101))
    pontuacao = 1000
    total_de_tentativas = 0

    print("Qual nível de dificuldade?")
    print("(1) Fácil (2) Médio (3) Difícil")

    nivel = int(input("Defina o nível: "))


    if(nivel==1):
        total_de_tentativas = 20
    elif(nivel==2):
        total_de_tentativas = 10
    else:
        total_de_tentativas = 5


    for rodada in range(1, total_de_tentativas+1):
        print("Tentativa {} de {}".format(rodada, total_de_tentativas))

        chute = int(input("Digite um número entre 1 e 100: "))
        print(end="\n")
        print("Você digitou ", chute)

        if(chute < 1 or chute > 100):
            print("Número inválido!")
            print("Você deve digitar um número entre 1 e 100!", end="\n\n")
            continue
        acertou = chute == numero_secreto
        maior   = chute > numero_secreto
        menor   = chute < numero_secreto

        if(acertou):
            print("Acertou, miserável! Você fez {} pontos!".format(int(pontuacao * (1+(nivel/10)))))
            break
        else:
            print("Erroooooooou!")
            if(maior):
                print("Seu chute foi maior que o número secreto", end="\n\n")
                if (rodada == total_de_tentativas):
                    print("O número secreto era {}. Você fez {}".format(numero_secreto, pontuacao))
            elif(menor):
                print("Seu chute foi menor que o número secreto", end="\n\n")
                if (rodada == total_de_tentativas):
                    print("O número secreto era {}. Você fez {}".format(numero_secreto, pontuacao))
            pontos_perdidos = abs(numero_secreto - chute)
            pontuacao = pontuacao - pontos_perdidos


    print("Fim do jogo!")

if(__name__ == "__main__"):
    jogar()