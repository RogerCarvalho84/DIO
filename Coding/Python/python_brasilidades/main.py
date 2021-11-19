from cpf_cnpj import Documento
from telefones_br import TelefonesBr
from datas_br import DatasBr



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

cadastro = DatasBr()
print(cadastro.dia_semana())
