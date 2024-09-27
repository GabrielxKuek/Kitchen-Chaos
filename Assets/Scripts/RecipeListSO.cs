using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// [CreateAssetMenu()] 
// we only need to create one, so after using it, we can comment it out
public class RecipeListSO : ScriptableObject
{
    public List<RecipeSO> recipeSOList;
} 