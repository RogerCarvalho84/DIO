from cpf_cnpj import Documento
from telefones_br import TelefonesBr
from datas_br import DatasBr
from acesso_cep import BuscaEndereco
from datetime import datetime, timedelta
import requests



"""
# validando cpf e cnpj

exemplo_cnpj = "35379838000112"
exemplo_cpf = "32405754851"
documento = Documento.cria_documento(exemplo_cpf)

print(documento)
"""

"""
# validando números de telefone

telefone = "551332514425"
telefone_objeto = TelefonesBr(telefone)
print(telefone_objeto)
"""




'''
# formatando datas

hoje = datetime.today()
print(hoje)
hoje_formatado = hoje.strftime("%d/%m/%Y %H:%M")
print(hoje_formatado)


cadastro = DatasBr()
print(cadastro.format_data())

hoje = DatasBr()
print(hoje.tempo_cadastro())

cep = 11025020
objeto_cep = BuscaEndereco(cep)
print(objeto_cep)
'''



cep = 11025020
objeto_cep = BuscaEndereco(cep)

bairro, cidade, uf = objeto_cep.acesso_via_cep()
print("{} {} - {}".format(bairro, cidade, uf))
