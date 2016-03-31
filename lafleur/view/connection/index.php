		<div id="content">
			<div class="sub-content">
				<div class="content">
					<div class="container">

				<?php if(!estConnecte()){ ?>
						<div class="form_connec">
							<form class="login" method="post" action="<?php echo WEBROOT."se_connecter/valideConnection"; ?>">
							    <h1>Se connecter</h1>
							    <fieldset class="inputs">
							        <input name="login" id="login" type="text" placeholder="Identifiant" autofocus required>   
							        <input name="password" id="password" type="password" placeholder="Mot de passe" required>
							    </fieldset>
							    <fieldset class="actions">
							        <input class="button" type="submit" id="submit" value="Se Connecter">
								</fieldset>
							</form>
							<div class="link_form">
								<!--<div class="link">
									<a href="<?php //echo WEBROOT."se_connecter/passe_oublie"; ?>">Mot de passe oublié ?</a> 
								</div> -->
								<div class="link">
									<a href="<?php echo WEBROOT."se_connecter/enregistrer"; ?>">S'enregistrer</a> 
								</div>
							</div>
						</div>
				<?php } ?>