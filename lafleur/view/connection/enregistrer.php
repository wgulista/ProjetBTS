		<div id="content">
			<div class="sub-content">
				<div class="content">
					<div class="container">
						<div class="form_connec">
							<form class="login" method="post" action="<?php echo WEBROOT."se_connecter/enregistrer"; ?>">
							    <h1>S'enregistrer</h1>
							    <?php
							    if(isset($msg)){
							    	foreach ($msg as $m) {
							    		echo "<li style='font-size:10px; height:20px; list-style:none; color:red;left:20px;'>".$m."</li>";
							    	}
							    }
							    ?>
							    <fieldset class="inputs">
							        <input name="nom" id="nom" value="<?php echo isset($nom) ? $nom : '' ?>" type="text" placeholder="Entrez votre nom" autofocus required>
							        <input name="prenom" id="prenom" value="<?php echo isset($prenom) ? $prenom : '' ?>" type="text" placeholder="Entrez votre prenom">
							        <input name="adresse" id="adresse" value="<?php echo isset($adresse) ? $adresse : '' ?>" type="text" placeholder="Entrez votre adresse"> 
							        <input name="phone" id="phone" value="<?php echo isset($phone) ? $phone : '' ?>" type="text" placeholder="Entrez votre numéro de téléphone"> 
							        <input name="mail" id="mail" value="<?php echo isset($mail) ? $mail : '' ?>" type="text" placeholder="Entrez votre email"> 
							        <input name="login" id="login" value="<?php echo isset($login) ? $login : '' ?>" type="text" placeholder="Entrez votre identifiant / login"> 
							        <input name="password" id="password" type="password" placeholder="Entrez votre mot de passe">
							        <input name="password_2" id="password_2" type="password" placeholder="Resaississez votre mot de passe">         
							    </fieldset>
							    <fieldset class="actions">
							        <input class="button" type="submit" id="submit" value="Envoyer">
								</fieldset>
							</form>
							<div class="link_form">
								<div class="link">
									<a href="<?php echo WEBROOT."se_connecter"; ?>">Se Connecter</a>
								</div>
								<!--<div class="link">
									<a href="<?php //echo WEBROOT."se_connecter/passe_oublie"; ?>">Mot de passe oublié ?</a> 
								</div> -->
							</div>
						</div>