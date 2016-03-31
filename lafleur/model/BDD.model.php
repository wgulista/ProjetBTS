<?php
	class BDD{
		private static $_host = "";
		private static $_username = "";
		private static $_password = "";
		private static $_database = "";  			
		private $monPdo;
		private static $INSTANCE;
		
		private function __construct(){
			try {
				if(self::$_database == null || self::$_host == null ||self::$_username == null) {
					throw new PDOException('vous devez positionner un nom de base de donnée, un nom d\'hote et un login');
				}
				$dsn = 'mysql:dbname='.self::$_database.';host='.self::$_host;
				$user = self::$_username;
				$password = self::$_password;
				$this->monPdo = new PDO($dsn, $user, $password);
				$this->monPdo->setAttribute(PDO::ATTR_ERRMODE,PDO::ERRMODE_WARNING);
				$this->monPdo->query("SET NAMES UTF8");
			} catch (PDOException $e) {
				die('Connexion échouée : ' . $e->getMessage());
				//TODO => au lieu de faire die, il faut lancer une exception
			}
		}
		
		public function _destruct(){
			$this->monPdo = null;
		}
		
		public static function getPdoInstance() {
			if(self::$INSTANCE == null) {
				self::$INSTANCE = new BDD();
			}
			return self::$INSTANCE;
		}
		
		public function getPdo() {
			return $this->monPdo;
		}
		/*
		**
		Fonction qui envoie des requete a utiliser pour les select
		@requete = requete sql
		@donnees = tableau qui recupere les valeur de drapeau
		@ligne = retourne un tableau à afficher ( associatif, numeric ou autre ) ex : PDO::FETCH_ASSOC
		**
		*/
		public function query($requete, $donnees = array(), $ligne = null){
			$req = $this->monPdo->prepare($requete);
			
			if(isset($donnees) && $donnees != null){
				$req->execute($donnees);
			}else{
				$req->execute();
			}

			if(isset($ligne) && ($ligne != null)){
				return $req->fetchAll($ligne);
			}else{
				return $req->fetchAll();
			}
		}

		/*
		**
		Fonction qui envoie des requete à utiliser pour les update, delete, 
		@sql = requete sql
		**
		*/
		public function nonQuery($sql){
			$req = $this->monPdo->exec($sql);
		}

		public function queryProtect($requete, $donnees = array()){
			$req = $this->monPdo->prepare($requete);
			if(isset($donnees) && $donnees != null){
				foreach ($donnees as $key => $value) {
	                if(is_int($value)){
	                	$param = PDO::PARAM_INT;
	                }elseif(is_bool($value)){
	                	$param = PDO::PARAM_BOOL;
	                }elseif(is_null($value)){
	                	$param = PDO::PARAM_NULL;
	                }elseif(is_string($value)){
	                	$param = PDO::PARAM_STR;
	                }else{
	                	$param = false;
	                }
	                   
	                if(isset($param)){
	                	$req->bindValue(":$key",$value,$param);
	                }
				}
				return $req->execute();
			}
		}
	}
?>