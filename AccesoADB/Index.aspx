<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="AccesoADB.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <title>Bootstrap demo</title>
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.0-alpha1/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-GLhlTQ8iRABdZLl6O3oVMWSktQOp6b7In1Zl3/Jr59b6EGGoI1aFkw7cmDA6j6gD" crossorigin="anonymous">
</head>
<body>
    <div class="container">
        <nav class="navbar navbar-expand-lg bg-body-tertiary">
            <div class="container-fluid">
                <a class="navbar-brand" href="#">Acceso a datos</a>
                <button class="navbar-toggler" type="button" data-bs-toggle="collapse" data-bs-target="#navbarNavDropdown" aria-controls="navbarNavDropdown" aria-expanded="false" aria-label="Toggle navigation">
                    <span class="navbar-toggler-icon"></span>
                </button>
                <div class="collapse navbar-collapse" id="navbarNavDropdown">
                    <ul class="navbar-nav">
                        <li class="nav-item dropdown">
                            <a class="nav-link dropdown-toggle text-bg-dark text-white" aria-current="page" href="#" role="button" data-bs-toggle="dropdown">Productos</a>
                            <ul class="dropdown-menu">
                                <li><a class="dropdown-item" href="paginas/ProductoDs.aspx">Productos</a></li>
  
                                <li><a class="dropdown-item" href="paginas/ProductoId.aspx">Id productos</a></li>
                            </ul>
                        </li>

                        <li class="nav-item dropdown ms-5">
                            <a class="nav-link dropdown-toggle text-bg-dark text-white" aria-current="page" href="#" role="button" data-bs-toggle="dropdown">Productos</a>
                            <ul class="dropdown-menu">
                                
                                <li><a class="dropdown-item" href="paginas/productosDr.aspx">Productos</a></li>
                                <li><a class="dropdown-item" href="paginas/ProductoNombre.aspx">Nombre productos</a></li>
                            </ul>
                        </li>

                        <li class="nav-item">
                            <a class="nav-link dropdown-toggle text-bg-dark text-white ms-4" href="paginas/Producto.aspx">Agregar producto</a>
                        </li>
                        </li>
                    </ul>
                </div>
            </div>
        </nav>
    </div>
    <script src="Pops/popper.min.js"></script>
    <script src="https://cdn.jsdelivr.net/npm/@popperjs/core@2.11.6/dist/umd/popper.min.js" integrity="sha384-oBqDVmMz9ATKxIep9tiCxS/Z9fNfEXiDAYTujMAeBAsjFuCZSmKbSSUnQlmh/jp3" crossorigin="anonymous"></script>
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.0-alpha1/dist/js/bootstrap.min.js" integrity="sha384-mQ93GR66B00ZXjt0YO5KlohRA5SY2XofN4zfuZxLkoj1gXtW8ANNCe9d5Y3eG5eD" crossorigin="anonymous"></script>
</body>
</html>
