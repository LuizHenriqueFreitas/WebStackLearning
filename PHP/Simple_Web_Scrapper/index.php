<!--// is that just a simple scrapper made 99% by AI to understand how it works-->

<?php

// get url link to scrapp
$url = "https://quotes.toscrape.com/?utm_source=chatgpt.com";

// initialize cURL lib tool
$ch = curl_init($url);

// cURL stuff
curl_setopt($ch, CURLOPT_RETURNTRANSFER, true);

// get html DOM fom the URL
$html = curl_exec($ch);
$dom = new DOMDocument();

libxml_use_internal_errors(true);

// load html and filter tags
$dom->loadHTML($html);
libxml_clear_errors();

$h2s = $dom->getElementsByTagName("h2");

foreach ($h2s as $h2) {
    echo $h2->textContent . "<br>";
}