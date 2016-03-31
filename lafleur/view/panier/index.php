		<div id="content">
			<div class="sub-content">
				<div class="content">
					<div class="container">
						<div class="panier">
							<?php if($ids): ?>
								<div class="prod_panier">
										<table>
											<tr>
												<th></th>
												<th>Description</th>
												<th>Prix TTC</th>
												<th>Quantité</th>
											</tr>
									<?php
										foreach($produit as $prod):
									?>
												<tr>
													<td><img src="<?php echo WEBROOT."design/".$prod->image; ?>" width="100" height="100" alt="<?php echo $prod->description; ?>" /></td>
													<td><h1><?php echo $prod->description; ?></h1></td>
													<td><h2><?php echo number_format($panier->prodTotalPrixTTC($prod->id), 2, '.', ''); ?> €</h2></td>
													<td>
														<input style="width:30px; text-align:center" type="text" value="<?php echo $_SESSION['produit'][$prod->id]; ?>" readonly />
														<a href="<?php echo WEBROOT."panier/add/".strip_tags($prod->id); ?>"><img src="<?php echo WEBROOT."design/css/add.gif"; ?>" width="14" height="16" alt="Ajouter"/></a>
														<a href="<?php echo WEBROOT."panier/del/".strip_tags($prod->id); ?>"><img src="<?php echo WEBROOT."design/css/delete.png"; ?>" width="14" height="16" alt="Supprimer"/></a>
													</td>
												</tr>
									<?php endforeach; ?>
									</table>
								</div>
								<div class="panier_total">
									<h2>Total :  <b><?php echo number_format($panier->prodTotalPrix(),2, '.', '').' €'; ?></b></h2><br/>
								<?php 
									if(isset($_SESSION['id']) && $panier->existeRemise($_SESSION['id'], $panier->prodTotalPrix()) == true && estConnecte()){ 
										if($panier->prodTotalPrix() >= 200 && $panier->prodTotalPrix() < 400){ ?>
											<h2>Remise:  <b>5 %</b></h2><br/>
									<?php }elseif($panier->prodTotalPrix() >= 400){ ?>
										<h2>Remise:  <b>10 %</b></h2><br/>
									<?php }else{ ?>
										<h2>Remise:  <b>Aucune</b></h2><br/>
									<?php }?>
										<h2>Total avec Remise :  <b><?php echo number_format($panier->totalAvecRemise($panier->prodTotalPrix(), $_SESSION['id']),2, '.', '').' €'; ?></b></h2><br/>
								<?php }else{ ?>
									<h2>Remise:  <b>Aucune</b></h2><br/>
								<?php } ?>
								
							   <?php if(isset($_SESSION['id']) && estConnecte() && $panier->existeRemise($_SESSION['id'], $panier->prodTotalPrix()) == true){ ?>
										<h2>Montant TV :  <b><?php echo number_format($panier->montantTVA($panier->totalAvecRemise($panier->prodTotalPrix(), $_SESSION['id'])),2, '.', '').' €'; ?></b></h2><br/>
										<h2>Total (TVA : 19.6%) :  <b><?php echo number_format(($panier->totalAvecRemise($panier->prodTotalPrix(), $_SESSION['id']) + $panier->montantTVA($panier->totalAvecRemise($panier->prodTotalPrix(), $_SESSION['id']))),2, '.', '').' €'; ?></b></h2><br/>
								<?php }else{ ?>
									<h2>Montant TV :  <b><?php echo number_format($panier->montantTVA($panier->prodTotalPrix()),2, '.', '').' €'; ?></b></h2><br/>
									<h2>Total (TVA : 19.6%) :  <b><?php echo number_format($panier->totalPrixTTC(),2, '.', '').' €'; ?></b></h2><br/>
								<?php } ?>
							<?php if(estConnecte()) { ?>
									<a href="<?php echo WEBROOT."panier/commander"; ?>">Créer un Devis</a>
							<?php }else{ ?>
									<h2>Vous devez posséder un compte pour pouvoir commander !</h2>
							<?php }?>
								</div>
							<?php 
							else:
								echo "<h1>Vous n'avez pas de produit dans votre panier !</h1>";
							endif;?>
						</div>
