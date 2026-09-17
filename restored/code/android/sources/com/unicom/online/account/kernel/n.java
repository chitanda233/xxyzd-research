package com.unicom.online.account.kernel;

import java.security.cert.X509Certificate;
import javax.net.ssl.X509TrustManager;

/* JADX INFO: loaded from: classes4.dex */
public final class n implements X509TrustManager {
    public final /* synthetic */ String b;

    public n(String str) {
        this.b = str;
    }

    @Override // javax.net.ssl.X509TrustManager
    public final void checkClientTrusted(X509Certificate[] x509CertificateArr, String str) {
    }

    @Override // javax.net.ssl.X509TrustManager
    public final void checkServerTrusted(X509Certificate[] x509CertificateArr, String str) {
        if (x509CertificateArr == null || x509CertificateArr.length == 0) {
            ao.v = "服务器证书链为空";
            throw new IllegalArgumentException("服务器证书链为空");
        }
        try {
            String name = x509CertificateArr[0].getSubjectDN().getName();
            if (ao.b(this.b, name)) {
                return;
            }
            ao.v = "自定义证书校验失败，将使用默认校验逻辑: domain=" + this.b + ", subjectName=" + name;
        } catch (Exception e) {
            as.b(e);
        }
    }

    @Override // javax.net.ssl.X509TrustManager
    public final X509Certificate[] getAcceptedIssuers() {
        return new X509Certificate[0];
    }
}
