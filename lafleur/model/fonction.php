<?php

	/**
	* Teste si un quelconque client est connecté
	* @return vrai ou faux 
	*/
	function estConnecte(){
		return isset($_SESSION['id']);
	}

	/**
	 * Enregistre dans une variable session les infos d'un visiteur
	 * @param $id 
	 * @param $nom
	 * @param $prenom
	 * @param $active Si c'est 1 le compte est active sinon si c'est 0 on redirige
	 */
	function connecter($id, $nom, $prenom, $active){
		if($active == 1){
			$_SESSION['id'] = $id;
			$_SESSION['nom']= $nom;
			$_SESSION['prenom']= $prenom;
		}else{
			header("Location: ".WEBROOT."se_connecter");
		}
	}

	/**
	 * teste si une chaîne a un format de code postal
	 *
	 * Teste le nombre de caractères de la chaîne et le type entier (composé de chiffres)
	 * @param $codePostal : la chaîne testée
	 * @return : vrai ou faux
	*/
	function estUnCp($codePostal)
	{
	   return strlen($codePostal)== 5 && estEntier($codePostal);
	}

	/**
	 * teste si une chaîne a un format de telephone
	 *
	 * Teste le nombre de caractères de la chaîne
	 * @param $tel : la chaîne testée
	 * @return : vrai ou faux
	*/
	function estUnTel($tel){
		if(is_numeric($tel) && strlen($tel) == 10 && preg_match("#^[\d]{10}$#", $tel)){
			return $tel;
		}
	}

	/**
	 * teste si une chaîne est un entier
	 *
	 * Teste si la chaîne ne contient que des chiffres
	 * @param $valeur : la chaîne testée
	 * @return : vrai ou faux
	*/
	function estEntier($valeur) 
	{
		return preg_match("/[^0-9]/", $valeur) == 0;
	}

	/**
	 * teste si c'est une chaine de caractere
	 *
	 * @param $valeur : la chaîne testée
	 * @return : vrai ou faux
	*/
	function estChaine($valeur){
		return ctype_alnum($valeur);
	}
	/**
	 * Teste si une chaîne a le format d'un mail
	 *
	 * Utilise les expressions régulières
	 * @param $mail : la chaîne testée
	 * @return : vrai ou faux
	*/
	function estUnMail($mail)
	{
		return  preg_match ('#^[\w.-]+@[\w.-]+\.[a-zA-Z]{2,6}$#', $mail);
	}

	/*
	 * Permet de faire une recherche sequentielle
	 *  
	 * @return : si les valeurs sont pareilles ou pas
	*/
	function rechercheSeq($valeur1, $valeur2){
		$ok = false;
		$i = 0;
		while($valeur1 != $valeur2 && $i < count($valeur1)){
			$i++;
		}
		if($valeur1 == $valeur2){
			$ok = true;
		}else{
			$ok = false;
		}
		return $ok;
	}
?>