<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
	
	<style>
    body{
      height: 700px;
      position: relative;
      background-color: rgb(28, 189, 111);
    }

    img{
			position: absolute;
      top: 75%;
      left: 50%;
      transform: translate(-50%, -50%);
			max-width: 100%;
		}
		
    #logo{
			position: absolute;
			top: 15%;
			left: 50%;
			transform: translate(-50%, -50%);
		}
		
		#info{
			color: white;
			font-family: arial;
      font-weight: bold;
			font-size: 36px;
      text-align: center;
      position: absolute;
      top: 37.5%;
      left: 50%;
      transform: translate(-50%, -50%);
		}
		
		#noencontrada{
      position: absolute;
      top: 30%;
      left: 50%;
      transform: translate(-50%, -50%);
			max-width: 50%;
			height: auto;
		}

    #error {
      align: center;
      color: white;
			font-family: arial;
      font-weight: bold;
			font-size: 36px;
      text-align: center;
      position: absolute;
      top: 65%;
      left: 50%;
      transform: translate(-50%, -50%);
    }
    </style>

    <script type="text/javascript">
        setTimeout(function() {
            window.location.href = "index.html";
        }, 4000);
    </script>

    <script type="text/javascript">

      if (window.addEventListener) {
      var codigo = "";
      window.addEventListener("keydown", function (e) {
          if (e.keyCode == 13) {
              window.location = "mostrar_producto.php?codigo=" + codigo;
              codigo = "";
          }
          else {
            codigo += String.fromCharCode(e.keyCode);
          }
      }, true);
}
</script>
</head>
<body>
    <?php
        include ("./inc/settings.php");
                
        try {
          $conn = new PDO("mysql:host=".$host.";dbname=$dbname", $username, $password);
          $conn->setAttribute(PDO::ATTR_ERRMODE, PDO::ERRMODE_EXCEPTION);
          $stmt = $conn->prepare("SELECT * FROM productos WHERE ProductoCodigo = ".$_GET["codigo"]);
          $stmt->execute();
        
          // set the resulting array to associative
          $result = $stmt->fetch(PDO::FETCH_ASSOC);
         
          $renglones=$stmt->rowCount();
          
          if ($renglones==1) {
            echo '<img id="logo" src="img/superdelsur.png" alt="" width="315" height="190">';
            echo "<p id='info'>";
            echo "".$result["ProductoNombre"]."<br>";
            echo "Precio: $".$result["ProductoPrecio"]."<br>";
            echo "Disponible: ".$result["ProductoCantidad"]."</p>";
            echo "<img src='".$result["ProductoImagen"]."' width='250px' height='250px'>";
      
          }
          else{
            echo "<img id='noencontrada' src='img/exclamation.png' alt='' width='250px' height='250px'>";
            echo '<p id="error">No fue posible leer el código de<br>barras.<br><br>Por favor intente de nuevo o solicite<br>ayuda del personal.</p>';
          }
          
        } catch(PDOException $e) {
          echo "<img id='noencontrada' src='img/exclamation.png' alt='' width='250px' height='250px'>";
          echo '<p id="error">No fue posible leer el código de<br>barras.<br><br>Por favor intente de nuevo o solicite<br>ayuda del personal.</p>';
        }
    ?>
</body>
</html>