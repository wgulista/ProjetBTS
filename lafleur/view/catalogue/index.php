	<div id="content">
			<div class="sub-content">
				<div class="content">
					<div class="container">
						<ul>
							<li style="margin-right : 50px;"><a href="<?php echo WEBROOT."catalogue/composite" ?>">Composite</a></li>
							<li><a href="<?php echo WEBROOT."catalogue/fleurs" ?>">Fleurs</a></li>
							<li><a href="<?php echo WEBROOT."catalogue/plantes" ?>">Plantes</a></li>
							<li><a href="<?php echo WEBROOT."catalogue/bulbes" ?>">Bulbes</a></li>
							<li><a href="<?php echo WEBROOT."catalogue/massifs" ?>">Massifs</a></li>
							<li><a href="<?php echo WEBROOT."catalogue/rosiers" ?>">Rosiers</a></li>
						</ul>
						<ul>
							<?php foreach($produit as $p) : ?>
							<li class="thumb">
								<img src="<?php echo WEBROOT."design/".$p->image; ?>" width="200" height="200" alt="<?php echo $p->description; ?>" />
								<div class="alt">
									<p>
										<?php echo '<br/><br/>'.$p->description.'<br/>'.$p->prix.' Euros<br/><br/>'; ?>
										<a href='<?php echo WEBROOT."panier/add/".$p->id; ?>'>Ajouter au panier</a>
									</p>
								</div>
							</li>
							<?php endforeach; ?>
						</ul>