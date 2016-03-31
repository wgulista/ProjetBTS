<!DOCTYPE html>
<html>
    <head>
		<meta http-equiv="content-type" content="text/html; charset=utf-8" />
		<meta name="Content-Language" content="fr">
        <meta name="Description" content="Vente de fleurs à prix compétitif.">
        <meta name="Keywords" content="cas lafleur, bts, bts sio, lafleur, vente lafleur">
        <meta name="Subject" content="Vente de fleurs">
        <meta name="Copyright" content="Lafleurs">
        <meta name="Rating" content="general">
        <meta name="Distribution" content="global">
        <?php if($action == 'commander'){ ?>
        	<link rel="stylesheet" href="<?php echo WEBROOT;?>design/css/bootstrap.min.css" />
        <?php } ?>
		<link rel="icon" type="image/png" href="<?php echo WEBROOT."design/" ?>css/lafleur.png" />
        <link rel="stylesheet" href="<?php echo WEBROOT;?>design/css/style.css" />
		<script type="text/javascript" src="<?php echo WEBROOT."design/js/jquery.js" ?>"></script>
		<script type="text/javascript" src="<?php echo WEBROOT."design/js/jquery-ui.js" ?>"></script>
		<script type="text/javascript" src="<?php echo WEBROOT."design/js/easing.js" ?>"></script>
		<script type="text/javascript" src="<?php echo WEBROOT."design/js/survol.js"; ?>"></script>
		<script type="text/javascript" src="<?php echo WEBROOT."design/js/hoverIntent.js" ?>"></script>
		<script type="text/javascript" src="<?php echo WEBROOT."design/js/flashyNav.js" ?>"></script>
		<script type="text/javascript" src="<?php echo WEBROOT."design/js/mousewheel.js" ?>"></script>
		<script type="text/javascript" src="<?php echo WEBROOT."design/js/mootools.js" ?>"></script>
		<script type="text/javascript" src="<?php echo WEBROOT."design/js/menu.js" ?>"></script>
		<script type="text/javascript" src="<?php echo WEBROOT."design/js/TweenMax.min.js" ?>"></script>
		<link type="text/css" rel="stylesheet" href="http://fonts.googleapis.com/css?family=PT+Sans:400,700,400italic|PT+Sans+Caption:400,700">
        <title><?php echo $titre; ?></title>
    </head>
	<body>
	<div id="global">
		<header>
			<a href="<?php echo WEBROOT; ?>">
				<span class="logo">
				</span>
			</a>
			<div class="menu">
				<ul class="nav nav1">
					<li><a href="<?php echo WEBROOT; ?>">ACCUEIL</a></li>
					<li><a href="<?php echo WEBROOT; ?>catalogue">VOIR LE CATALOGUE</a></li>
					<li><a href="<?php echo WEBROOT; ?>panier">VOIR SON PANIER</a></li>
			<?php if(!estConnecte()){ ?>
					<li><a href="<?php echo WEBROOT; ?>se_connecter">SE CONNECTER</a></li>
			<?php }else{ ?>
					<li style="background:red;"><a href="<?php echo WEBROOT; ?>se_connecter/deconnecter">SE DECONNECTER</a></li>
			<?php } ?>
					<li><a href="<?php echo WEBROOT; ?>contact">CONTACT</a></li>
				</ul>
			</div>
			<div class="total">
				<p>Total (TVA) : <?php echo number_format($panier->totalPrixTTC(),2, '.', '').' €'; ?></p>
			</div>
		</header>