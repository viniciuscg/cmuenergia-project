-- e) Liste o nome, o estoque mínimo e o estoque atual de todos os produtos, cujo estoque atual está abaixo do estoque mínimo (Dica: Use "HAVING").

select p.Nome, p.EstoqueMinimo, COALESCE(sum(t.quantidade), 0) as Estoque 
from produto p 
left join transacao t on t.IdProduto = p.IdProduto
group by p.IdProduto
having COALESCE(sum(t.quantidade), 0) < p.EstoqueMinimo;