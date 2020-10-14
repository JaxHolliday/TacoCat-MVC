  # TacoCat-MVC 

The Taco Cat coding challenge is based on the more traditional “Reverse a string” exercise but ultimately determines if a word or phrase is a palindrome.  

  - The Reverse a string exercise in some form has been used by technology companies such as Amazon, Microsoft, VMware and Norton to assess a candidate’s ability to code an impromptu algorithm.
  # Example: the user enters “developer” the output is “repoleved”.

# Code - HomeController 
 - Code shown is for the code used to add the "solve" View
 - The 2nd solve is for the program to run it / give solution
```sh
[HttpGet]
        public IActionResult Solve()
        {
            ViewData["ReverseWord"] = "";
            ViewData["OtherWord"] = "";
            return View();
        }

        [HttpPost]
        public IActionResult Solve(string theWord, string anotherWord)
        {
            if (string.IsNullOrWhiteSpace(theWord) || string.IsNullOrWhiteSpace(anotherWord))
            {
                return View();
            }
            var result = theWord.ToLower().Replace(" ", "");
            
            var reverse = string.Join("", result.Reverse().ToArray());
            ViewData["ReverseWord"] = reverse;           
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
        }

        public IActionResult Result(FizzBuzzModel model)
        {
            return View(model);
        }
```
