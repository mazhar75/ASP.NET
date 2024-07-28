using BooksDukan.Data;
using BooksDukan.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;

namespace BooksDukan.Controllers;

public class ProductController : Controller
{  
    private readonly ApplicationDbContext _db;
    public ProductController(ApplicationDbContext db)
    {
            _db=db;
    }
    public IActionResult Index()
    {   
        List<Products> objCategoryList = _db.Product.ToList();
        return View(objCategoryList);
    }
    public IActionResult Create()
    {
        return View();
    }
    [HttpPost]
     public IActionResult Create(Category obj)
    {
        if(ModelState.IsValid)
        {
        _db.Categories.Add(obj);
        _db.SaveChanges();
        TempData["success"]="Category created sucessfully";
        return RedirectToAction("Index");
        }
        return View();

    }
     public IActionResult Edit(int? id)
    {  
        if(id==null || id==0){
            return NotFound();
        }
        Products product  = _db.Product.Find(id);

        if(product == null){
            return NotFound();
        }
        return View(product);
    }
    [HttpPost]
     public IActionResult Edit(Products obj)
    {
        if(ModelState.IsValid)
        {
        _db.Product.Update(obj);
        _db.SaveChanges();
         TempData["success"]="product updated sucessfully";
        return RedirectToAction("Index");
        }
        return View();

    }
     public IActionResult Delete(int? id)
    {  
        if(id==null || id==0){
            return NotFound();
        }
        Category category = _db.Categories.Find(id);

        if(category == null){
            return NotFound();
        }
        return View(category);
    }
    [HttpPost, ActionName("Delete")]
     public IActionResult DeletePOST(int? id)
    {   
        Category? obj = _db.Categories.Find(id);
        if(obj == null){

            return NotFound();
            
        }
        _db.Categories.Remove(obj);
        _db.SaveChanges();
         TempData["success"]="Category deleted sucessfully";
        return RedirectToAction("Index");

    }
}