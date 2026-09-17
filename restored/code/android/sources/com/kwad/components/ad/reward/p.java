package com.kwad.components.ad.reward;

import com.baidu.mobads.sdk.internal.cb;
import com.kwad.sdk.core.response.model.AdInfo;
import com.kwad.sdk.core.response.model.AdTemplate;
import com.kwad.sdk.utils.br;
import org.json.JSONObject;

/* JADX INFO: loaded from: classes3.dex */
public final class p {
    public static void b(final AdTemplate adTemplate, AdInfo adInfo) {
        final String strBY = com.kwad.sdk.core.response.helper.a.bY(adInfo);
        com.kwad.sdk.core.d.c.d("ServerCallbackHandle", "handleRewardVerify callbackUrl: " + strBY);
        if (br.isNullString(strBY)) {
            return;
        }
        com.kwad.sdk.utils.i.execute(new Runnable() { // from class: com.kwad.components.ad.reward.p.1
            @Override // java.lang.Runnable
            public final void run() {
                try {
                    com.kwad.sdk.core.network.c cVarDoGet = com.kwad.sdk.h.ES().doGet(strBY, null);
                    if (cVarDoGet == null) {
                        J("Network Error: url invalid");
                        return;
                    }
                    if (cVarDoGet.code == 200) {
                        a aVar = new a(cVarDoGet.aSY);
                        if (aVar.isValid()) {
                            hI();
                            return;
                        } else {
                            J(aVar.errorMsg);
                            return;
                        }
                    }
                    J("Network Error: " + cVarDoGet.aSY);
                } catch (Throwable th) {
                    J("Request Error: " + th.getMessage());
                }
            }

            private void hI() {
                com.kwad.components.core.p.a.vX().h(adTemplate, 0, cb.o);
            }

            private void J(String str) {
                com.kwad.components.core.p.a.vX().h(adTemplate, 1, str);
            }
        });
    }

    static class a {
        private String errorMsg;
        private boolean uf;

        public a(String str) {
            JSONObject jSONObject;
            this.errorMsg = "-";
            try {
                jSONObject = new JSONObject(str);
            } catch (Throwable th) {
                th.printStackTrace();
                this.uf = false;
                this.errorMsg = "数据解析失败";
                jSONObject = null;
            }
            parseJson(jSONObject);
        }

        public final boolean isValid() {
            return this.uf;
        }

        private void parseJson(JSONObject jSONObject) {
            if (jSONObject != null) {
                this.uf = jSONObject.optBoolean("isValid");
                this.errorMsg = jSONObject.toString();
            }
        }
    }
}
