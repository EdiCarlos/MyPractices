<?php
if(isset($_POST['name'])
{
$var = $_POST['name'];
print $var;s
}

?>
<html>
<head>
</head>
<body>
<form enctype="" action="<?php print $_SERVER('PHP_SELF'); ?>" method="post">
<label>username : </label>
<input type="text" name="name" />
<input type="submit" name="sub" text="submit" />
</form>
</body>
</html>