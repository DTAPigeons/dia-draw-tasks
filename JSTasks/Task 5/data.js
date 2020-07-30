const data = {
    "parts": [
      {
        "classification": "engine",
        "id": "warp",
        "price": 25
      },
      {
        "classification": "engine",
        "id": "fusion",
        "price": 50
      },
      {
        "classification": "body",
        "id": "aluminium",
        "price": 50
      },
      {
        "classification": "body",
        "id": "titanium",
        "price": 120
      },
      {
        "classification": "power generator",
        "id": "nuclear",
        "price": 200
      },
      {
        "classification": "power generator",
        "id": "solar",
        "price": 50
      }
    ],
    "parts compatibility": {
      "nuclear:power generator": [
        "titanium:body",
        "warp:engine",
        "fusion:engine"
      ],
      "solar:power generator": [
        "titanium:body",
        "aluminium:body",
        "warp:engine"
      ]
    }
  }
  