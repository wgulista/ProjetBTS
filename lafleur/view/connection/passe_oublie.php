		<div id="content">
			<div class="sub-content">
				<div class="content">
					<div class="container">
						<div class="form_connec">
							<form class="login" method="post" action="<?php echo WEBROOT."se_connecter/passe_oublie"; ?>">
							    <h1>Se connecter</h1>
							    <fieldset class="inputs">
							        <input id="login" type="text" placeholder="Entrez votre email" autofocus required>   
							    </fieldset>
							    <fieldset class="actions">
							        <input class="button" type="submit" id="submit" value="Envoyer">
								</fieldset>
							</form>
							<div class="link_form">
								<div class="link">
									<a href="<?php echo WEBROOT."se_connecter"; ?>">Se Connecter</a>
								</div>
								<div class="link">
									<a href="<?php echo WEBROOT."se_connecter/enregistrer"; ?>">S'enregistrer</a> 
								</div>
							</div>
						</div>