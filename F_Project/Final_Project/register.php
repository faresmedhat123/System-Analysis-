<!DOCTYPE html>
<html lang="en">
<head>
<meta charset="UTF-8">
<meta name="viewport" content="width=device-width,initial-scale=1.0">
<title>Register - Metro</title>

<link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.8/dist/css/bootstrap.min.css" rel="stylesheet">
<link rel="stylesheet"
href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/6.5.0/css/all.min.css">

<style>

body{
height:100vh;
display:flex;
justify-content:center;
align-items:center;
background: linear-gradient(135deg,#f5f5f5,#e9ecef);
font-family:Arial;
}

.register-box{
width:420px;
background:white;
padding:45px;
border-radius:25px;
box-shadow:0 10px 35px rgba(0,0,0,.12);
}

.icon-circle{
width:80px;
height:80px;
background:#f3f3f3;
border-radius:50%;
display:flex;
align-items:center;
justify-content:center;
margin:auto;
font-size:32px;
}

.form-control{
height:55px;
border-radius:12px;
}

.btn-register{
height:55px;
border-radius:12px;
font-weight:bold;
}

.google-btn{
border:1px solid #ddd;
height:55px;
border-radius:12px;
background:#fff;
}

a{
text-decoration:none;
}

</style>
</head>
<body>

<div class="register-box">

<div class="icon-circle mb-4">
<i class="fa-solid fa-user-plus"></i>
</div>

<h2 class="text-center fw-bold">
Create Account
</h2>

<p class="text-center text-muted mb-4">
Join us and start your journey
</p>

<form action="save_user.php" method="POST">

<div class="mb-3">
<input
type="text"
name="name"
class="form-control"
placeholder="Full Name"
required>
</div>

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

<div class="mb-4">
<input
type="password"
name="confirm_password"
class="form-control"
placeholder="Confirm Password"
required>
</div>

<button class="btn btn-dark w-100 btn-register">
<i class="fa-solid fa-user-plus me-2"></i>
Create Account
</button>

<div class="text-center my-3 text-muted">
OR
</div>

<button type="button"
class="google-btn w-100">
<i class="fa-brands fa-google me-2"></i>
Sign up with Google
</button>

<p class="text-center mt-4">
Already have an account?
<a href="login.php" class="fw-bold">
Login
</a>
</p>

</form>

</div>

</body>
</html>