-- d) Liste o nome e o estoque de todos os produtos, no dia 31/12/2022 (Dica: Use "LEFT JOIN").

select p.Nome, COALESCE(sum(t.quantidade), 0) as Estoque 
from produto p 
left join transacao t on t.IdProduto = p.IdProduto and t.Data <= "2022-12-31" 
group by p.IdProduto;