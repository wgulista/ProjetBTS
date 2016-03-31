<?php
	if(isset($action)){
		switch ($action) {
			case 'commander':{
				if(!estConnecte()){
					header("Location: ".WEBROOT."panier");
				}else{
					// Si la session produit n'est pas vide
					if(!empty($_SESSION['produit'])){
						$msg = array();
						$total = number_format($panier->totalPrixTTC(),2, '.', '');
						$ids = array_keys($_SESSION['produit']);
						$implode = implode("','", $ids);
						$sql = "SELECT id, description, prix, image FROM produit WHERE id IN ('$implode')";
						$produit = $bdd->query($sql , null, PDO::FETCH_OBJ);
						$idClient = $_SESSION['id'];
						$client_infos = $bdd->query('SELECT nom, prenom, adresse, email, phone FROM client WHERE id=:id',array('id' => $idClient), PDO::FETCH_OBJ);
						$client_infos = array_shift($client_infos);
						
						if(isset($params[0])){
							if(count($_POST) > 0 && isset($_POST)){
								if(!empty($_POST['cp']) && !empty($_POST['ville'])){
									if(estUnCp($_POST['cp']) && estChaine($_POST['ville'])){
										if($params[0] == 'ok'){
											require_once(PATH."view/panier/okCommande.php");
											try{
												$pdf = new HTML2PDF('P', 'A4', 'fr');
												$pdf->pdf->SetDisplayMode('fullpage');
												$pdf->WriteHTML($clean);
												ob_clean();
												$pdf->Output("commande.pdf", 'D');
											}catch(HTML2PDF_exception $e){
												die($e);
											}
										}
										$nomPrenom = $_POST['nom']." ".$_POST['prenom'];
										$bdd->creerCommande($total, $nomPrenom, $_POST['adresse'], $_POST['cp'], $_POST['ville'], $_POST['mail'], $_POST['phone'], $produit);
									}else{
										$msg[] = "Votre code postale ou votre ville n'est pas correct !";
									}
								}else{
									$msg[] = "Vous avez oublié(e) de renseigner les champs soit du code postale ou de la ville";
								}
							}else{
								header("Location: ".WEBROOT."panier");
							}
						}
						require_once(PATH."view/panier/commander.php");
					}else{
						header("Location: ".WEBROOT."panier");
					}
				}
				break;
			}
			case 'add':{
				$_GET = explode('/', $_GET['page']);
				$id = htmlspecialchars(addslashes($_GET[2]));
				$produit = array_shift($bdd->query("SELECT id FROM produit where id=:id", array('id'=>$id), PDO::FETCH_OBJ));
				$i = 0;
				while ($id != $produit->id && $i < count($produit)){
					$i++;
				}
				if($id == $produit->id){
					$panier->add($id);
					header('Location: '.WEBROOT.'panier');
				}else{
					header('Location: '.WEBROOT.'panier');
				}
				break;
			}
			case 'del':{
				$_GET = explode('/', $_GET['page']);
				$id = htmlspecialchars(addslashes($_GET[2]));
				if(!empty($id)){
					$panier->del($id);
					header('Location: '.WEBROOT.'panier');
				}else{
					header('Location: '.WEBROOT.'panier');
				}
				break;	
			}
			default:{
				$ids = array_keys($_SESSION['produit']);
				if(estConnecte()){
					$client = $_SESSION['id'];
				}
				if(empty($ids)){
					$produit = array();
				}else{
					$implode = implode("','", $ids);
					try {
						$sql = "SELECT id, description, prix, image FROM produit WHERE id IN ('$implode')";
						$produit = $bdd->query($sql , null, PDO::FETCH_OBJ);
						
					}catch(Exception $e){
						echo 'Erreur SQL : '.$e->getMessage().'<br />'.$sql;'<br />';
					}
				}
				require_once(PATH."view/panier/index.php");
				break;
			}
		}
	}
?>