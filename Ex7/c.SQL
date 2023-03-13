-- c) Liste as unidades de medida e a quantidade de produtos que existem para cada uma.

select UnidadeMedida, count(*) as Quantidade from produto group by UnidadeMedida;