# 🎭 Playwright를 이용한 E2E 통합 테스트

[Playwright](https://playwright.dev/)란 Microsoft에서 제공하는 E2E 자동화된 테스트 도구입니다.

이를 이용하여 넥슨 홈페이지부터 충전창까지 결제 수단별 테스트를 진행하였습니다.

## 개발 목적

매주 1회 새벽에 진행하는 결제 테스트를 자동화

## 개발 내용

- Microsoft에서 개발한 [Playwright](https://playwright.dev)라는 E2E 테스트 자동화 도구 사용
  - 팀 내 기술 스택인 C# 언어로 진행할 수 있는 테스트 도구였기에 선택

## 소개

Playwright는 테스트에 필요한 탭을 사용범위에 따라 브라우저, 컨텍스트, 페이지 등을 베이스 인터페이스로 제공합니다.

세부적인 설정이 필요없는 경우에는 Page 클래스를 사용하면 되나, 통합 테스트 시 브라우저가 Visible하기를 원하여(visibility=invisible is default) playwright 최상위 베이스클래스를 오버라이딩하여 설정을 변경하였습니다.

커밋된 내용은 Example이며, 상세한 테스트 코드는 보안상 커밋하지 않았습니다.
