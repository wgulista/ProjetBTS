		<div id="content">
			<div class="sub-content">
				<div class="content">
					<div class="container">
						<div class="form_connec">
							<form class="login" method="post" action="<?php echo WEBROOT."panier/commander/ok"; ?>">
							    <h1>Commander</h1>
								<?php
									if(isset($msg)){
										foreach($msg as $m){
											echo "<li>".$m."</li>";
										}
									}
								?>
							    <fieldset class="inputs">
							        <input name="nom" id="nom" type="text" readonly value="<?php echo $client_infos->nom; ?>">
							        <input name="prenom" id="prenom" type="text" readonly value="<?php echo $client_infos->prenom; ?>">
							        <input name="adresse" id="adresse" type="text" readonly  value="<?php echo $client_infos->adresse; ?>"> 
							        <input name="cp" id="cp" type="text" placeholder="Entrez votre code postale"> 
							        <input name="ville" id="ville" type="text" placeholder="Entrez votre ville"> 
							        <input name="mail" id="mail" type="text" readonly  value="<?php echo $client_infos->email; ?>"> 
							        <input name="phone" id="phone" type="text" readonly value="<?php echo '0'.$client_infos->phone; ?>">        
							    </fieldset>
							    <fieldset class="actions">
							        <input class="button" type="submit" onclick="return confirm('Etes vous sur de vouloir commander cette commande ?');" id="submit" value="Envoyer">
								</fieldset>
							</form>
						</div>
