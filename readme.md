# ［改訂新版］実戦で役立つ C#プログラミングのイディオム/定石＆パターン サポートページ

[［改訂新版］実戦で役立つ C#プログラミングのイディオム/定石＆パターン](https://gihyo.jp/book/2024/978-4-297-14307-7)のサポートページです。

## 書誌情報

著書: 出井秀行  
出版社: 技術評論社  
ページ数: B5変形判／496ページ  
ISBN: 978-4-297-14307-7  

## 概要

2017年に出版した『実戦で役立つ C#プログラミングのイディオム/定石＆パターン』の改訂版です。

初版では.NET Framework4.6＋C#6.0を扱っていましたが、この改訂版では「.NET8.0＋C#12.0」がターゲットになっています。

本書は、「C#のより良い書き方」、「.NETのクラスの活用」、「オブジェクト指向プログラミング」、「良いコードを書く指針」という4つの柱からなり、それぞれの視点で、現場で利用されているイディオムや定石、デザインパターンなどわかりやすく丁寧に解説しています。

## 対象読者

- 入門書をひととおり理解したレベルのプログラマー
- 実践的な知識を学びたいプログラミング初心者

C#初心者が手に取ることを念頭に置いて執筆していますが、中級者以上の方にも読んでいただける内容になっていると自負しています。

## 正誤表

みつかり次第、ここに掲載いたします。

本ページに掲載されていない誤植や間違いを見つけた方は，技術評論社の[問い合わせページ](https://gihyo.jp/site/inquiry/book?ISBN=978-4-297-14307-7)からお知らせください．

## 書籍掲載のソースコードと演習問題解答　（準備中）

当GitHubリポジトリのsrcフォルダーとanswerフォルダーに格納してあります。

Clone等してご利用ください。


## 目次

### Part 1 ［準備編］C#プログラミングのイディオム/定石&パターン

#### Chapter 1　オブジェクト指向プログラミングの基礎

1.1　クラス  
1.2　構造体   
1.3　値型と参照型  
1.4　静的メンバーと静的クラス  
1.5　名前空間  
1.6　継承  
1.7　null許容参照型  

#### Chapter 2　C#でプログラムを書いてみよう

2.1　距離換算プログラム  
2.2　売り上げ集計プログラム  

#### Chapter 3　ラムダ式とLINQの基礎

3.1　ラムダ式以前  
3.2　ラムダ式  
3.3　List\<T\>クラスとラムダ式の組み合わせ  
3.4　LINQ to Objectsの基礎  

### Part 2 ［基礎編］C#プログラミングのイディオム/定石&パターン

#### Chapter 4　基本イディオム

4.1　初期化に関するイディオム  
4.2　判定と分岐に関するイディオム  
4.3　繰り返しのイディオム  
4.4　nullに関するイディオム  
4.5　列挙型に関するイディオム  
4.6　その他のイディオム  

#### Chapter 5　クラスに関するイディオム

5.1　プロパティに関するイディオム  
5.2　メソッドに関するイディオム  
5.3　コンストラクターに関するイディオム  
5.4　さらに進んだクラスの定義  

#### Chapter 6　文字列の操作

6.1　文字列の比較  
6.2　文字列の判定  
6.3　文字列の検索と抽出  
6.4　文字列の変換  
6.5　文字列の連結と分割  
6.6　その他の文字列操作  

#### Chapter 7　配列とList<T>の操作

7.1　本章で共通に使用するコード  
7.2　要素の設定  
7.3　コレクションの集計  
7.4　コレクションの判定  
7.5　単一の要素の取得  
7.6　複数の要素の取得  
7.7　その他の処理（変換，ソート，連結など）  

#### Chapter 8　ディクショナリの操作

8.1　Dictionary\<TKey, TValue\>の基本操作  
8.2　ディクショナリの応用  
8.3　ディクショナリを使ったサンプルプログラム  

#### Chapter 9　日付，時刻の操作

9.1　DateTime構造体  
9.2　日時のフォーマット  
9.3　DateTimeの比較  
9.4　日時の計算（基礎）  
9.5　日時の計算（応用）  

### Part 3 ［実践編］C#プログラミングのイディオム/定石&パターン

#### Chapter 10　ファイルの操作

10.1　テキストファイルの入力  
10.2　テキストファイルへの出力  
10.3　ファイルの操作  
10.4　ディレクトリの操作  
10.5　パス名の操作  
10.6　その他のファイル操作  

#### Chapter 11　正規表現を使った高度な文字列処理

11.1　正規表現とは    
11.2　文字列の判定  
11.3　文字列の検索  
11.4　文字列の置換と分割  
11.5　さらに高度な正規表現  

#### Chapter 12　シリアル化，逆シリアル化

12.1　JSONデータのシリアル化/逆シリアル化の基礎  
12.2　JsonSerializerクラスの既定の動作を変更する  
12.3　XMLシリアル化  

#### Chapter 13　LINQを使いこなす

13.1　本章で利用する書籍データなどについて  
13.2　入力ソースが1つの場合のLINQ  
13.3　入力ソースが複数の場合のLINQ  

#### Chapter 14　非同期/並列プログラミング

14.1　非同期処理，並列処理の必要性  
14.2　async/await以前の非同期プログラミング  
14.3　async/awaitを使った非同期プログラミング  
14.4　HttpClientを使った非同期処理　async/awaitの応用例  
14.5　並列処理プログラミング  

### Part 4 ［ステップアップ編］C#プログラミングのイディオム/定石&パターン

#### Chapter 15　実践オブジェクト指向プログラミング

15.1　ポリモーフィズムの基礎  
15.2　Template Methodパターン  
15.3　Strategyパターン  
15.4　依存性の注入パターン  

#### Chapter 16　C#を使いこなす

16.1　インデクサー  
16.2　ジェネリックス  
16.3　反復子  
16.4　拡張メソッド  
16.5　属性  
16.6　タプル  
16.7　パターンマッチング  

#### Chapter 17　スタイル，ネーミング，コメント

17.1　スタイルに関する指針  
17.2　ネーミングに関する指針  
17.3　コメントに関する指針  

#### Chapter 18　良いコードを書くための指針

18.1　変数に関する指針  
18.2　メソッドに関する指針  
18.3　クラスに関する指針  
18.4　例外処理に関する指針  
18.5　その他の好ましくないプログラミング  

#### Appendix　その他のプログラミングの定石

A.1　プロセスの起動  
A.2　バージョン情報の取得  
A.3　アプリケーション構成ファイルの取得  
A.4　ZIPアーカイブファイルの操作  
A.5　協定世界時とタイムゾーン  

さらに詳しい目次は、[技術評論社の書籍ページ](https://gihyo.jp/book/2024/978-4-297-14307-7)に掲載してあります。

### コラム

オブジェクトとインスタンス  
Visual Studioのデバッグの基本  
コードスニペットでプロパティを楽々定義  
プロジェクトに新しいクラスを追加する  
constのバージョン管理問題  
浮動小数点型の比較  
前置++と後置++の違い  
オブジェクトどうしの比較  
文字列は不変オブジェクト  
foreachやforのループの中で  
リストの要素を削除してはいけない  
DateOnly構造体とTimeOnly構造体  
グローバルusing  
usingディレクティブを自動で挿入する  
文字エンコーディングを指定したファイル出力  
行頭、行末の意味を変更し、複数行モードにする  
正規表現のキャッシュ  
大文字・小文字を区別せずマッチさせる  
ECMAScript準拠の動作を有効にする  
typeof演算子とGetTypeメソッド  
DefaultIfEmptyメソッド  
LINQの集合演算子  
Zipメソッドの使い方  
lock構文で排他制御  
ボックス化とボックス化解除  
record型とwith式  
Visual Studioの［名前の変更］機能を使う  
XMLコメント（ドキュメントコメント）とVisual Studio  
プログラミングの一般原則  
Visual Studioのコードメトリックスの使い方  
コンパイラの警告は無視してはいけない  
