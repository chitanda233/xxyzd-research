package com.kwad.components.ad.reward.retryReward;

import android.content.SharedPreferences;
import com.kwad.sdk.service.ServiceProvider;
import com.kwad.sdk.utils.ah;
import com.kwad.sdk.utils.ai;
import com.kwad.sdk.utils.bi;
import com.kwad.sdk.utils.bq;
import com.kwad.sdk.utils.bz;
import com.kwad.sdk.utils.i;
import java.util.ArrayList;
import java.util.HashMap;
import java.util.Iterator;
import java.util.Map;
import org.json.JSONObject;

/* JADX INFO: loaded from: classes3.dex */
public final class d {
    private final Map<String, f> Bt = new HashMap();
    private final ArrayList<String> Bu = new ArrayList<>();
    private final Object lock = new Object();

    static class a {
        private static final d By = new d();
    }

    public static d kD() {
        return a.By;
    }

    public final void kE() {
        if (bz.aD(((com.kwad.sdk.service.a.f) ServiceProvider.get(com.kwad.sdk.service.a.f.class)).getApiVersion(), "4.9.20.1")) {
            i.execute(new bi() { // from class: com.kwad.components.ad.reward.retryReward.d.1
                @Override // com.kwad.sdk.utils.bi
                public final void doTask() {
                    SharedPreferences sharedPreferencesIe;
                    try {
                        synchronized (d.this.lock) {
                            long jCurrentTimeMillis = System.currentTimeMillis();
                            Map<String, ?> mapHN = ai.hN("ksadsdk_reward_task_cache");
                            com.kwad.sdk.core.d.c.d("RewardRetryTaskCacheManager", "initRewardTaskAsync map cost time: " + (System.currentTimeMillis() - jCurrentTimeMillis));
                            boolean zHM = ah.hM("ksadsdk_reward_task_cache");
                            if (mapHN != null && !mapHN.isEmpty()) {
                                for (Map.Entry<String, ?> entry : mapHN.entrySet()) {
                                    if (entry != null) {
                                        Object value = entry.getValue();
                                        if (value instanceof String) {
                                            String strDecodeKsSdk = (String) value;
                                            if (com.kwad.sdk.core.a.c.isEncodeKsSdk(strDecodeKsSdk)) {
                                                strDecodeKsSdk = com.kwad.sdk.core.a.c.decodeKsSdk(strDecodeKsSdk);
                                            }
                                            if (!strDecodeKsSdk.trim().isEmpty()) {
                                                JSONObject jSONObject = new JSONObject(strDecodeKsSdk);
                                                f fVar = new f();
                                                fVar.parseJson(jSONObject);
                                                com.kwad.sdk.core.d.c.d("RewardRetryTaskCacheManager", "json parse " + entry.getKey() + com.kwad.sdk.core.response.helper.a.aD(com.kwad.sdk.core.response.helper.e.eM(fVar.mAdTemplate)) + " cost time: " + (System.currentTimeMillis() - jCurrentTimeMillis));
                                                if (fVar.BG * 1000 > jCurrentTimeMillis - fVar.BH) {
                                                    d.this.Bt.put(entry.getKey(), fVar);
                                                } else {
                                                    if (zHM) {
                                                        d.this.Bu.add(entry.getKey());
                                                    } else {
                                                        ai.ay("ksadsdk_reward_task_cache", entry.getKey());
                                                    }
                                                    com.kwad.sdk.core.d.c.d("RewardRetryTaskCacheManager", "remove task: " + entry.getKey() + com.kwad.sdk.core.response.helper.a.aD(com.kwad.sdk.core.response.helper.e.eM(fVar.mAdTemplate)) + " out time: " + ((jCurrentTimeMillis - fVar.BH) - (fVar.BG * 1000)));
                                                }
                                            }
                                        }
                                    }
                                }
                                if (zHM && (sharedPreferencesIe = bq.ie("ksadsdk_reward_task_cache")) != null) {
                                    SharedPreferences.Editor editorEdit = sharedPreferencesIe.edit();
                                    Iterator it = d.this.Bu.iterator();
                                    while (it.hasNext()) {
                                        editorEdit.remove((String) it.next());
                                    }
                                    editorEdit.apply();
                                }
                            }
                            com.kwad.sdk.core.d.c.d("RewardRetryTaskCacheManager", " all items: " + d.this.Bt.size() + " cost time: " + (System.currentTimeMillis() - jCurrentTimeMillis));
                        }
                    } catch (Throwable th) {
                        ServiceProvider.reportSdkCaughtException(th);
                    }
                }
            });
        }
    }

    public final void a(final String str, final f fVar) {
        if (this.Bt.containsKey(str)) {
            com.kwad.sdk.core.d.c.d("RewardRetryTaskCacheManager", "addTask key: " + str + com.kwad.sdk.core.response.helper.a.aD(com.kwad.sdk.core.response.helper.e.eM(fVar.mAdTemplate)) + " already exist");
        } else {
            this.Bt.put(str, fVar);
            i.execute(new bi() { // from class: com.kwad.components.ad.reward.retryReward.d.2
                @Override // com.kwad.sdk.utils.bi
                public final void doTask() {
                    synchronized (d.this.lock) {
                        ai.ax(str, fVar.toJson().toString());
                        com.kwad.sdk.core.d.c.d("RewardRetryTaskCacheManager", "addTask key: " + str + com.kwad.sdk.core.response.helper.a.aD(com.kwad.sdk.core.response.helper.e.eM(fVar.mAdTemplate)) + " save success");
                    }
                }
            });
        }
    }

    public final f X(String str) {
        return this.Bt.get(str);
    }
}
