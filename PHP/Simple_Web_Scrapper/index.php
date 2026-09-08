<?php

$url = "https://quotes.toscrape.com/?utm_source=chatgpt.com";

$ch = curl_init($url);

curl_setopt($ch, CURLOPT_RETURNTRANSFER, true);

$html = curl_exec($ch);

$dom = new DOMDocument();

libxml_use_internal_errors(true);

$dom->loadHTML($html);
libxml_clear_errors();

$h2s = $dom->getElementsByTagName("h2");

foreach ($h2s as $h2) {
    echo $h2->textContent . "<br>";
}