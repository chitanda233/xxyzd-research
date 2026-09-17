package com.unicom.online.account.kernel;

import android.text.TextUtils;
import java.security.cert.X509Certificate;
import javax.net.ssl.HostnameVerifier;
import javax.net.ssl.HttpsURLConnection;
import javax.net.ssl.SSLPeerUnverifiedException;
import javax.net.ssl.SSLSession;

/* JADX INFO: loaded from: classes4.dex */
public final class ah implements HostnameVerifier {
    @Override // javax.net.ssl.HostnameVerifier
    public final boolean verify(String str, SSLSession sSLSession) {
        if (!TextUtils.isEmpty(str) && sSLSession != null) {
            try {
                if (ao.b(str, ((X509Certificate) sSLSession.getPeerCertificates()[0]).getSubjectDN().getName())) {
                    return true;
                }
                return HttpsURLConnection.getDefaultHostnameVerifier().verify(str, sSLSession);
            } catch (SSLPeerUnverifiedException e) {
                as.b(e);
            }
        }
        return false;
    }
}
