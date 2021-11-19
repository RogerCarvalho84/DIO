from cpf_cnpj import Documento
from validate_docbr import CNPJ
from telefones_br import TelefonesBr
import re

"""
exemplo_cnpj = "35379838000112"
exemplo_cpf = "32405754851"
documento = Documento.cria_documento(exemplo_cpf)

print(documento)
"""

texto = "meu telefone é 13981732740 ou 1332514425"

telefone = "551332514425"
telefone_objeto = TelefonesBr(telefone)

#print(telefone_objeto)

#padrao = "([0-9]{2,3})?([0-9]{2})([0-9]{4,5})([0-9]{4})"

#resposta = re.search(padrao,telefone)
#print(resposta.group(2))

print(telefone_objeto)