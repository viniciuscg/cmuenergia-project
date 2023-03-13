-- b) Liste o nome e a unidade de medida de todos os produtos, cuja unidade de medida é em gramas ou em unidades.

select Nome, UnidadeMedida from produto where UnidadeMedida = "g" or  UnidadeMedida = "un";