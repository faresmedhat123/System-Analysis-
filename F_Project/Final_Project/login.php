<!DOCTYPE html>
<html lang="en">
<head>
<meta charset="UTF-8">
<meta name="viewport" content="width=device-width,initial-scale=1.0">
<title>Login - Metro</title>

<link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/css/bootstrap.min.css" rel="stylesheet">

<link rel="stylesheet"
href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/6.5.0/css/all.min.css">

<style>

body{
height:100vh;
display:flex;
justify-content:center;
align-items:center;
background:linear-gradient(135deg,#f5f5f5,#e6ecff);
font-family:Arial;
}

.login-box{
width:420px;
background:#fff;
padding:45px;
border-radius:25px;
box-shadow:0 10px 35px rgba(0,0,0,.12);
}

.icon-circle{
width:80px;
height:80px;
border-radius:50%;
background:#f3f3f3;
display:flex;
justify-content:center;
align-items:center;
margin:auto;
font-size:30px;
}

.form-control{
height:55px;
border-radius:12px;
}

.btn-login{
height:55px;
border-radius:12px;
font-weight:bold;
}

.google-btn{
height:55px;
border:1px solid #ddd;
border-radius:12px;
background:#fff;
}

a{
text-decoration:none;
}

</style>

</head>
<body>

<div class="login-box">

<div class="icon-circle mb-4">
<i class="fa-solid fa-user-lock"></i>
</div>

<h2 class="text-center fw-bold">
Welcome Back
</h2>

<p class="text-center text-muted mb-4">
Login to your account
</p>

<form action="login_check.php" method="POST">

<div class="mb-3">
<input
type="email"
name="email"
class="form-control"
placeholder="Email Address"
required>
</div>

<div class="mb-3">
<input
type="password"
name="password"
class="form-control"
placeholder="Password"
required>
</div>

<div class="d-flex justify-content-between mb-4">
<div>
<input type="checkbox">
Remember me
</div>

<a href="#">
Forgot Password?
</a>
</div>

<button type="submit"
class="btn btn-dark w-100 btn-login">
<i class="fa-solid fa-right-to-bracket me-2"></i>
Login
</button>

<div class="text-center my-3 text-muted">
OR
</div>

<button type="button" class="google-btn w-100">
<i class="fa-brands fa-google me-2"></i>
Login with Google
</button>

<p class="text-center mt-4">
Not registered yet?
<a href="register.php" class="fw-bold">
Create Account
</a>
</p>

</form>

</div>

</body>
</html>