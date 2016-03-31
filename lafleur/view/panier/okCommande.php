<?php ob_start(); ?>
<style type="text/css">
	table{
		width : 100%;
		color : #717375;
	}
	table td{
		padding:10;
	    color:#fff;
	    font-size: 16px;
	    background-color:#222;
	    font-weight:normal;
	    border-right:1px dotted #666;
	    border-top:3px solid #666;
	    -moz-box-shadow:0px -1px 4px #000;
	    -webkit-box-shadow:0px -1px 4px #000;
	    box-shadow:0px -1px 4px #000;
	    text-shadow:0px 0px 1px #fff;
	    text-shadow:1px 1px 1px #000;
	}
	table strong{
		color : #000;
	}
</style>
<page backtop="20mm" backleft="10mm" backright="10mm" backbottom="15mm" backimg="<?php echo PATH."design/css/lafleur.png"; ?>">
	<table>
		<tr>
			<td style="width:50%;text-align:left;background-color:#9DD929;">
				<strong>La Fleur</strong><br>
				61 Avenue du Président Wilson<br>
				94230 Cachan<br>
				Telephone : <strong>01 41 98 61 81</strong><br>
				Site : <strong>ens-cachan.fr</strong>
			</td>
			<td style="width:50%;text-align:right;background-color:#9DD929;">
				<?php echo $client_infos->nom; ?> <?php echo $client_infos->prenom; ?><br/>
				<?php echo $client_infos->adresse; ?><br/>
				Numero commande<br><strong>00 000 00 00 0 0</strong>
			</td>
		</tr>
	</table>
	<table>
		<tr>
			<td style="width:25%;text-align:center;"></td>
			<td style="width:25%;text-align:center;">Description</td>
			<td style="width:25%;text-align:center;">Prix Unitaire</td>
			<td style="width:25%;text-align:center;">Quantité</td>
		</tr>
		<?php foreach ($produit as $p) { ?>
		<tr>
			<td style="width:25%;text-align:center;"><img src="<?php echo PATH."design/".$p->image; ?>" width="100" height="100" alt="<?php echo $p->description; ?>" /></td>
			<td style="width:25%;text-align:center;"><?php echo $p->description ?></td>
			<td style="width:25%;text-align:center;"><?php echo $p->prix ?></td>
			<td style="width:25%;text-align:center;"><?php echo $_SESSION['produit'][$p->id];  ?></td>
		</tr>
		  <?php } ?>
	</table>
	<table>
		<tr></tr>
		<tr>
			<td style="width:100%;background-color:#9DD929;text-align:center;">
				<h2>Total (TVA) :  <b><?php echo $total.' €'; ?></b></h2>
			</td>
		</tr>
		<tr></tr>
	</table>
</page>
<?php $clean = ob_get_clean(); ?>