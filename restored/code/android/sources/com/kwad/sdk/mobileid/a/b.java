package com.kwad.sdk.mobileid.a;

import com.alipay.sdk.app.AlipayApi;
import com.kwad.sdk.core.network.d;
import com.kwad.sdk.i;
import com.kwad.sdk.utils.an;
import java.text.SimpleDateFormat;
import java.util.Date;
import java.util.UUID;
import org.json.JSONObject;

/* JADX INFO: loaded from: classes3.dex */
public final class b extends d {
    private static String biY;

    private static String SD() {
        return "300012755841";
    }

    private static String SE() {
        return "CB607A51A7A639E532D288AB8C963DB6";
    }

    @Override // com.kwad.sdk.core.network.d, com.kwad.sdk.core.network.b
    public final void buildBaseBody() {
    }

    @Override // com.kwad.sdk.core.network.b, com.kwad.sdk.core.network.f
    public final String getUrl() {
        return i.Fq();
    }

    @Override // com.kwad.sdk.core.network.b, com.kwad.sdk.core.network.f
    public final JSONObject getBody() {
        try {
            biY = SB();
            String strSC = SC();
            String strAn = an(strSC, biY);
            putBody(com.alipay.sdk.m.x.a.k, strSC);
            putBody("sign", strAn);
            putBody("traceId", biY);
            putBody(AlipayApi.c, SD());
            putBody("interfaceVersion", "2.0");
        } catch (Throwable th) {
            reportSdkCaughtException(th);
        }
        return this.mBodyParams;
    }

    private static String SB() {
        return UUID.randomUUID().toString().replace("-", "");
    }

    private static String an(String str, String str2) {
        return an.md5(SD() + str + str2 + "2.0" + SE());
    }

    private static String SC() {
        return new SimpleDateFormat("yyyyMMddHHmmssSSS").format(new Date());
    }
}
