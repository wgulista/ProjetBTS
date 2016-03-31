<?php
	if(isset($action)){
		switch ($action) {
			case 'passe_oublie':{
				if(!estConnecte()){
					require_once(PATH."view/connection/passe_oublie.php");
				}else{
					header("Location: ".WEBROOT."catalogue");
				}
				break;
			}
			case 'enregistrer':{
				if(!estConnecte()){
					if(count($_POST) > 0 && isset($_POST)){
						$i = 0;
						$msg = array();

						if(!empty($_POST['nom']) && estChaine($_POST['nom'])){
							$nom = htmlentities($_POST['nom']);
						}else{
							$msg[] = "Votre nom n'est pas correct !";
						}

						if(!empty($_POST['prenom']) && estChaine($_POST['prenom'])){
							$prenom = htmlentities($_POST['prenom']);
						}else{
							$msg[] = "Votre prenom n'est pas correct !";
						}

						if(!empty($_POST['adresse'])){
							$adresse = strip_tags($_POST['adresse']);
						}else{
							$msg[] = "Votre adresse n'est pas correct !";
						}


						if(!empty($_POST['mail']) && !empty($_POST['login'])){
							// Recherche : Si login existant ou pas
							$selectLogin = array_shift($bdd->query("SELECT login FROM client where login=:login",array('login'=>addslashes($_POST['login'])),PDO::FETCH_OBJ));
							if(!empty($selectLogin->login) && rechercheSeq($_POST['login'], $selectLogin->login)){
								$msg[] = 'Le login que vous voulez utilisé est déjà utilisé !';
							}else{
								// Teste longueur du login
								if(strlen($_POST['login']) >= 5 && estChaine($_POST['login'], true)){
									$login = !empty($_POST['login']) ? addslashes($_POST['login']) : '';
								}else{
									$msg[] = 'Votre login doit etre composé de plus de cinq caracteres !';
								}
							}
							// Recherche email
							$selectMail = array_shift($bdd->query("SELECT email FROM client where email=:email",array('email'=>addslashes($_POST['mail'])),PDO::FETCH_OBJ));
							if(!estUnMail($_POST['mail'])){
								$msg[] = 'Votre email est incorrect !';
							}else{
								if(!empty($_POST['mail']) && isset($selectMail->email) && estUnMail($_POST['mail']) && rechercheSeq($_POST['mail'], $selectMail->email)){
									$msg[] = 'Cet email est déjà utilisé !';
								}else{
									$mail = !empty($_POST['mail']) ? addslashes($_POST['mail']) : '';
								}
							}
						}
						// Teste du code postale
						if(!empty($_POST['phone'])){
							if(!estUnTel($_POST['phone'])){
								$msg[] = 'Votre numero de telephone est incorrect !';
							}else{
								if(estUnTel($_POST['phone'])){
									$phone = !empty($_POST['phone']) ? addslashes($_POST['phone']) : '';
								}
							}
						}
						
						// Teste longueur mot de passe 
						if(!empty($_POST['password'])){
							if(strlen($_POST['password']) >= 7){
								$password = !empty($_POST['password']) ? addslashes($_POST['password']) : '';
							}else{
								$msg[] = 'Votre password doit etre composé de plus de sept caracteres !';
							}
							$password = !empty($_POST['password']) ? addslashes($_POST['password']) : '';
						}
						$password2 = !empty($_POST['password_2']) ? addslashes($_POST['password_2']) : '';
						
						if(!empty($password) && !empty($password2)){
							if($password == $password2){
								$passFinal = $password;
							}else{
								$msg[] = 'Les mots de passes ne sont pas identiques !';
							}
						}

						if(!empty($nom) && !empty($prenom) && !empty($adresse) && !empty($mail) && !empty($phone) && !empty($login) && !empty($passFinal) && !empty($token)){
							$bdd->query(
								"INSERT INTO client(nom, prenom, adresse, email, phone, login, password, active, token)
								 VALUES(:nom, :prenom, :adresse, :email, :phone, :login, :password, :active, :token)",
								 array(
								 	'nom' => $nom,
								 	'prenom' => $prenom,
								 	'adresse' => $adresse,
								 	'email' => $mail,
								 	'phone' => $phone,
								 	'login' => $login,
								 	'password' => $passFinal,
								 	'active' => 1,
								 	'token' => $token
								));
							/*$tokenAdd = array_shift($bdd->query("SELECT email, token FROM client where email=:email",
								array('email' => $mail),
								PDO::FETCH_OBJ
							));

							$to = "wasim.gulistan@gmail.com";
							$sujet = "Activation du compte";
							$header = "From: wasim.gulistan@gmail.com \n";
							$header .= "Reply-To: $mail";
							$message = "Bonjour".ucfirst($nom)." ".ucfirst($prenom)."\n";
							$message .= "Pour activer votre compte :\n";
							$message .= "http://".WEBROOT."se_connecter/active/".$token*/
							$msg[] = 'Votre compte a été créer, vous pouvez désormais vous connectez !';
						}
					}
					require_once(PATH."view/connection/enregistrer.php");
				}else{
					header("Location: ".WEBROOT."catalogue");
				}
				break;
			}
			case 'deconnecter':{
				session_unset();
				session_destroy();
				header("Location: ".WEBROOT."se_connecter");
			}
			case 'valideConnection':{
				if(count($_POST) > 0 && isset($_POST)){
					$login = addslashes($_POST['login']);
					$mdp = addslashes($_POST['password']);
					if(!empty($login) && !empty($mdp)){
						$client = $bdd->query("SELECT id, nom, prenom, active FROM client WHERE login=:login AND password=:mdp",
										  array('login' => $login,'mdp' => $mdp), PDO::FETCH_ASSOC);
						$client = array_shift($client);	

						if(!empty($client) && is_array($client))
						{
							$id = isset($client['id']) ? $client['id'] : "";
							$nom =  isset($client['nom']) ? $client['nom'] : "";
							$prenom = isset($client['prenom']) ? $client['prenom'] : "";
							if(isset($client['active']) && $client['active'] == 1){
								connecter($id,$nom,$prenom, $client['active']);
								header("Location: ".WEBROOT."catalogue");
							}else{
								header("Location: ".WEBROOT."se_connecter");
							}
						}else{
							header("Location: ".WEBROOT."se_connecter");
						}	 
					}else{
						header("Location: ".WEBROOT."se_connecter");
					}
				}else{
					header("Location: ".WEBROOT."se_connecter");
				}
				break;
			}
			default:{
				if(!estConnecte()){
					require_once(PATH."view/connection/index.php");
				}else{
					header("Location: ".WEBROOT."catalogue");
				}
				break;
			}
		}
	}
?>