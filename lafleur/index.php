<?php
	ini_set('display_errors',1); 
	DEFINE("PATH", str_replace("index.php", "", $_SERVER['SCRIPT_FILENAME'])); //  utiliser pour inclure un/des fichier(s) 
	DEFINE("WEBROOT", str_replace("index.php", "", $_SERVER['SCRIPT_NAME'])); //  utiliser pour inclure des image, liens, fichiers ou autre seulement pour le dossier VIEW / DESIGN
	function chargerClasse($classname){
		$classe = PATH.'model/'.$classname.'.model.php';
		if(file_exists($classe)){
			require_once($classe);
		}
	}
	
	spl_autoload_register ('chargerClasse'); //charge automatiquement toute les classe
	
	@session_start();
	
	$bdd = BDD::getPdoInstance();  // Instanciation de la connection a la base de donnee
	$panier = new panier($bdd); // instanciation du panier
	$token = md5(time() * rand(time(), (time()*555)));
	
	require_once(PATH.'model/fonction.php');

	if(isset($_REQUEST['page'])){
		$path = explode('/', isset($_REQUEST['page']) ? $_REQUEST['page'] : '');
		$controller = strip_tags(htmlspecialchars($path[0]));
		$action = isset($path[1]) ? strip_tags(htmlspecialchars($path[1])) : '';
		
		$params = array();
		if(count($path)>2){
			$params = array_slice($path, 2);
		}
		$page = PATH."controller/".$controller.".controller.php";
		if($controller){
			switch($controller){
				case 'index':{
					$titre = "La Fleur - Accueil";
					$page = PATH."controller/index.controller.php";
					break;
				}
				case 'index.php':{
					$titre = "La Fleur - Accueil";
					$page = PATH."controller/index.controller.php";
					break;
				}
				case $controller:{
					$titre = "La Fleur - ".ucfirst($controller);
					$page = PATH."controller/".$controller.".controller.php";
				}
			}
		}else{
			$titre = "La Fleur - Accueil";
			$page = PATH."controller/index.controller.php";
		}			
		if(file_exists($page)){
			require_once(PATH."design/header.php");
			require_once($page);
			require_once(PATH."design/footer.php");
		}else{
			require_once(PATH."design/header.php");
			require_once(PATH."view/404.view.php");
			require_once(PATH."design/footer.php");
		}
	}else{
		require_once(PATH."design/header.php");
		require_once(PATH."view/404.view.php");
		require_once(PATH."design/footer.php");
	}
?>