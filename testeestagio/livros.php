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



function deletarLivro($livro_id, $conn) {
    $sql = "DELETE FROM livros WHERE id = $livro_id";
    if ($conn->query($sql) === TRUE) {
        echo "Livro deletado com sucesso!";
    } else {
        echo "Erro ao deletar livro: " . $conn->error;
    }

    function visualizarLivros($conn) {
        $sql = "SELECT * FROM livros";
        $result = $conn->query($sql);
    
        if ($result->num_rows > 0) {
            echo "Livros disponíveis:<br>";
            while ($row = $result->fetch_assoc()) {
                echo "ID: " . $row["id"] . " - Título: " . $row["titulo"] . " - Autor: " . $row["autor"] . " - Ano: " . $row["ano_publicacao"] . "<br>";
            }
        } else {
            echo "Não há livros disponíveis.";
        }
    }
    function adicionarLivro($titulo, $autor, $ano, $conn) {
        $sql = "INSERT INTO livros (titulo, autor, ano_publicacao) VALUES ('$titulo', '$autor', '$ano')";
        if ($conn->query($sql) === TRUE) {
            echo "Livro adicionado com sucesso!";
        } else {
            echo "Erro ao adicionar livro: " . $conn->error;
        }
    }
    

adicionarLivro("O Senhor dos Anéis", "J.R.R. Tolkien", $livros);
adicionarLivro("2018", "Vingadores Ultimato", $livros);
adicionarLivro("2023", "Napoleão", $livros);

listarLivros($livros);

removerLivro(1, $livros);

listarLivros($livros);
?>
<?php


$servername = "biblioteca";
$username = "user";
$password = "pasword";
$dbname = "biblioteca";

// Conectando ao banco de dados
$conn = new mysqli($servername, $username, $password, $dbname);

// Verificando a conexão
if ($conn->connect_error) {
    die("Erro de conexão: " . $conn->connect_error);
}

// Função para adicionar um novo livro ao banco de dados
function adicionarLivro($titulo, $autor, $ano, $conn) {
    $sql = "INSERT INTO livros (titulo, autor, ano) VALUES ('$titulo', '$autor', '$ano')";

    if ($conn->query($sql) === TRUE) {
        echo "Livro adicionado com sucesso.\n";
    } else {
        echo "Erro ao adicionar livro: " . $conn->error;
    }
}

// Função para listar todos os livros disponíveis no banco de dados
function listarLivros($conn) {
    $sql = "SELECT * FROM livros";
    $result = $conn->query($sql);

    if ($result->num_rows > 0) {
        echo "Livros disponíveis:\n";
        while ($row = $result->fetch_assoc()) {
            echo "Título: " . $row['titulo'] . " - Autor: " . $row['autor'] . " - Ano: " . $row['ano'] . "\n";
        }
    } else {
        echo "Não há livros disponíveis no momento.\n";
    }
}

// Função para remover um livro do banco de dados
function removerLivro($id, $conn) {
    $sql = "DELETE FROM livros WHERE id = $id";

    if ($conn->query($sql) === TRUE) {
        echo "Livro removido com sucesso.\n";
    } else {
        echo "Erro ao remover livro: " . $conn->error;
    }
}


adicionarLivro("O Senhor dos Anéis", "J.R.R. Tolkien", 1954, $conn);


listarLivros($conn);


removerLivro(X, $conn);


listarLivros($conn);


$conn->close();
?>
