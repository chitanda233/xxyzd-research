package ms.bz.bd.c.Pgl;

import android.content.Context;
import com.bytedance.framwork.core.sdkmonitor.SDKMonitor;
import com.bytedance.framwork.core.sdkmonitor.SDKMonitorUtils;
import java.util.ArrayList;
import org.json.JSONArray;
import org.json.JSONException;
import org.json.JSONObject;

/* JADX INFO: loaded from: classes4.dex */
public final class t1 extends pblx {
    private SDKMonitor c;

    final class pgla implements SDKMonitor.IGetExtendParams {
        final /* synthetic */ JSONObject c;
        final /* synthetic */ String tt;

        pgla(JSONObject jSONObject, String str) {
            this.c = jSONObject;
            this.tt = str;
        }
    }

    @Override // ms.bz.bd.c.Pgl.pblx
    public final void c(long j, long j2, String str, String str2, int i) {
        SDKMonitor sDKMonitor = this.c;
        if (sDKMonitor == null) {
            return;
        }
        sDKMonitor.monitorSLA(j, j2, str, (String) null, str2, i, (JSONObject) null);
    }

    @Override // ms.bz.bd.c.Pgl.pblx
    public final void c(String str, JSONObject jSONObject, JSONObject jSONObject2, JSONObject jSONObject3) {
        com.volcengine.mobsecBiz.matrix.pgla.a(16777217, 0, 0L, "666dd2", new byte[]{20, 56, 68, 2, 95, 36, 39, com.sigmob.sdk.archives.tar.e.J, 113, com.sigmob.sdk.archives.tar.e.I, 41, 32, 105, 31, 92, 8, com.sigmob.sdk.archives.tar.e.L, 25, 102, com.sigmob.sdk.archives.tar.e.K, 34, 38, 5, 3, 94, com.sigmob.sdk.archives.tar.e.O, 35, 30, 100, com.sigmob.sdk.archives.tar.e.I, 41, com.sigmob.sdk.archives.tar.e.M, 72, 21, 27, 104, com.sigmob.sdk.archives.tar.e.R, 90, 39});
        if (this.c == null) {
            return;
        }
        try {
            JSONObject jSONObject4 = new JSONObject();
            jSONObject4.put((String) com.volcengine.mobsecBiz.matrix.pgla.a(16777217, 0, 0L, "6fc593", new byte[]{com.sigmob.sdk.archives.tar.e.L, 97, 2, 87, 15, 39, com.sigmob.sdk.archives.tar.e.H, 73, com.sigmob.sdk.archives.tar.e.K, 104, 34}), str);
            jSONObject4.put((String) com.volcengine.mobsecBiz.matrix.pgla.a(16777217, 0, 0L, "f76843", new byte[]{116, com.sigmob.sdk.archives.tar.e.L, 81, 73, 12, 43, 119, 15}), jSONObject);
            jSONObject4.put((String) com.volcengine.mobsecBiz.matrix.pgla.a(16777217, 0, 0L, "5b8f2e", new byte[]{41, 101, 95, 0, 4, 113}), jSONObject2);
            jSONObject4.put((String) com.volcengine.mobsecBiz.matrix.pgla.a(16777217, 0, 0L, "e12643", new byte[]{com.sigmob.sdk.archives.tar.e.R, 60, 70, com.sigmob.sdk.archives.tar.e.T, 19, com.sigmob.sdk.archives.tar.e.H, 116}), jSONObject3);
            com.byazt.nr.m.uj((String) com.volcengine.mobsecBiz.matrix.pgla.a(16777217, 0, 0L, "177c0d", new byte[]{13, 16, 112, com.sigmob.sdk.archives.tar.e.N, 60, 86, 17}), jSONObject4.toString());
        } catch (JSONException e) {
            com.byazt.nr.m.c(e);
        }
        if (jSONObject.length() > 0 || jSONObject2.length() > 0) {
            this.c.monitorEvent(str, jSONObject, jSONObject2, jSONObject3);
        }
    }

    @Override // ms.bz.bd.c.Pgl.pblx
    public final boolean c(String str) {
        JSONObject jSONObject;
        String str2;
        String str3;
        String string;
        String string2;
        Context contextTt = pblw.c().tt();
        if (str != null) {
            try {
                jSONObject = new JSONObject(str);
            } catch (JSONException unused) {
                com.volcengine.mobsecBiz.matrix.pgla.a(16777217, 0, 0L, "34a302", new byte[]{com.sigmob.sdk.archives.tar.e.I, com.sigmob.sdk.archives.tar.e.K, 31});
                jSONObject = null;
            }
        } else {
            jSONObject = null;
        }
        if (jSONObject == null) {
            return false;
        }
        try {
            string = jSONObject.getString((String) com.volcengine.mobsecBiz.matrix.pgla.a(16777217, 0, 0L, "73ee60", new byte[]{com.sigmob.sdk.archives.tar.e.M, com.sigmob.sdk.archives.tar.e.M, 29, 46, 8, 46, com.sigmob.sdk.archives.tar.e.H}));
            try {
                string2 = jSONObject.getString((String) com.volcengine.mobsecBiz.matrix.pgla.a(16777217, 0, 0L, "bed5fc", new byte[]{123, 104, 4, 85, 102, 117, 104, 64}));
                try {
                    ArrayList arrayList = new ArrayList();
                    ArrayList arrayList2 = new ArrayList();
                    JSONArray jSONArray = jSONObject.getJSONArray((String) com.volcengine.mobsecBiz.matrix.pgla.a(16777217, 0, 0L, "e4603c", new byte[]{119, 57, 75, 66, 5, 115, com.sigmob.sdk.archives.tar.e.Q, 39, 75, 115}));
                    JSONArray jSONArray2 = jSONObject.getJSONArray((String) com.volcengine.mobsecBiz.matrix.pgla.a(16777217, 0, 0L, "743353", new byte[]{com.sigmob.sdk.archives.tar.e.L, com.sigmob.sdk.archives.tar.e.K, 80, 72, 24, com.sigmob.sdk.archives.tar.e.H, 1, 39, 78, 112}));
                    for (int i = 0; i < jSONArray.length(); i++) {
                        arrayList.add(jSONArray.getString(i));
                    }
                    for (int i2 = 0; i2 < jSONArray2.length(); i2++) {
                        arrayList2.add(jSONArray2.getString(i2));
                    }
                    if (arrayList.size() <= 0 || arrayList2.size() <= 0) {
                        return false;
                    }
                    SDKMonitorUtils.setConfigUrl(string, arrayList);
                    SDKMonitorUtils.setDefaultReportUrl(string, arrayList2);
                } catch (JSONException unused2) {
                    str2 = string;
                    str3 = string2;
                    com.volcengine.mobsecBiz.matrix.pgla.a(16777217, 0, 0L, "15fa4c", new byte[]{com.sigmob.sdk.archives.tar.e.K, com.sigmob.sdk.archives.tar.e.J, 24, 42, 2});
                    string = str2;
                    string2 = str3;
                }
            } catch (JSONException unused3) {
                str2 = string;
                str3 = null;
                com.volcengine.mobsecBiz.matrix.pgla.a(16777217, 0, 0L, "15fa4c", new byte[]{com.sigmob.sdk.archives.tar.e.K, com.sigmob.sdk.archives.tar.e.J, 24, 42, 2});
                string = str2;
                string2 = str3;
                jSONObject.remove((String) com.volcengine.mobsecBiz.matrix.pgla.a(16777217, 0, 0L, "15488b", new byte[]{35, 56, 73, 74, 14, 114, 7, 38, 73, 123}));
                jSONObject.remove((String) com.volcengine.mobsecBiz.matrix.pgla.a(16777217, 0, 0L, "0159f0", new byte[]{com.sigmob.sdk.archives.tar.e.K, com.sigmob.sdk.archives.tar.e.N, 86, 66, 75, com.sigmob.sdk.archives.tar.e.K, 6, 34, 72, 122}));
                SDKMonitorUtils.initMonitor(contextTt, string, jSONObject, new pgla(jSONObject, string2));
                this.c = SDKMonitorUtils.getInstance(string);
                return true;
            }
        } catch (JSONException unused4) {
            str2 = null;
        }
        jSONObject.remove((String) com.volcengine.mobsecBiz.matrix.pgla.a(16777217, 0, 0L, "15488b", new byte[]{35, 56, 73, 74, 14, 114, 7, 38, 73, 123}));
        jSONObject.remove((String) com.volcengine.mobsecBiz.matrix.pgla.a(16777217, 0, 0L, "0159f0", new byte[]{com.sigmob.sdk.archives.tar.e.K, com.sigmob.sdk.archives.tar.e.N, 86, 66, 75, com.sigmob.sdk.archives.tar.e.K, 6, 34, 72, 122}));
        SDKMonitorUtils.initMonitor(contextTt, string, jSONObject, new pgla(jSONObject, string2));
        this.c = SDKMonitorUtils.getInstance(string);
        return true;
    }

    @Override // ms.bz.bd.c.Pgl.pblx
    public final void tt(long j, long j2, String str, String str2, int i) {
        SDKMonitor sDKMonitor = this.c;
        if (sDKMonitor == null) {
            return;
        }
        sDKMonitor.monitorApiError(j, j2, str, (String) null, str2, i, (JSONObject) null);
    }
}
