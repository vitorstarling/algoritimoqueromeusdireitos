<?php


$livros = [];


function adicionarLivro($titulo, $autor, &$livrosArray) {
    $livro = [
        'titulo' => $titulo,
        'autor' => $autor
    ];
    $livrosArray[] = $livro;
}


function listarLivros(&$livrosArray) {
    if (empty($livrosArray)) {
        echo "Não há livros disponíveis no momento.\n";
    } else {
        echo "Livros disponíveis:\n";
        foreach ($livrosArray as $livro) {
            echo "Título: " . $livro['titulo'] . " - Autor: " . $livro['autor'] . "\n";
        }
    }
}


function removerLivro($indice, &$livrosArray) {
    if (isset($livrosArray[$indice])) {
        unset($livrosArray[$indice]);
        $livrosArray = array_values($livrosArray); // Reindexa o array após a remoção
        echo "Livro removido com sucesso.\n";
    } else {
        echo "Livro não encontrado.\n";
    }
}


adicionarLivro("O Senhor dos Anéis", "J.R.R. Tolkien", $livros);
adicionarLivro("2018", "Vingadores Ultimato", $livros);
adicionarLivro("2023", "Napoleão", $livros);

listarLivros($livros);

removerLivro(1, $livros);

listarLivros($livros);
?>
