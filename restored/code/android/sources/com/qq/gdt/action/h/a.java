package com.qq.gdt.action.h;

import com.byazt.nys.PluginConstants;
import com.bytedance.sdk.openadsdk.mediation.MediationConstant;
import com.kwad.sdk.core.scene.URLPackage;
import com.qq.gdt.action.d;
import com.qq.gdt.action.e;
import com.qq.gdt.action.i.h;
import com.qq.gdt.action.i.n;
import com.qq.gdt.action.i.o;
import com.qq.gdt.action.i.p;
import java.util.ArrayList;
import java.util.Arrays;
import java.util.HashSet;
import java.util.Iterator;
import java.util.List;
import org.json.JSONArray;
import org.json.JSONException;
import org.json.JSONObject;

/* JADX INFO: loaded from: classes3.dex */
public class a {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    static String[] f3073a;
    static List b;

    static {
        String[] strArr = {"ipcUserActionSetId", "ipcAppSecretKey", "ipcChannelId", "ipcSaveFileTimeEnd", "ipcUserUniqueId", "ipcChannelType", "ipcSaveFileTimeSuccess"};
        f3073a = strArr;
        b = Arrays.asList(strArr);
    }

    public static void a(com.qq.gdt.action.f.a.a aVar) {
        ArrayList arrayList = new ArrayList();
        arrayList.add(aVar);
        a(arrayList);
    }

    private static void a(String str, JSONObject jSONObject, com.qq.gdt.action.e.a.b bVar) {
        boolean z;
        try {
            z = (str.equals("http://api.datanexus.qq.com/data-nexus-trace/log") || str.equals("https://api.datanexus.qq.com/data-nexus-trace/log")) && com.qq.gdt.action.b.a(d.a().g()).m() == 0;
        } catch (Exception e) {
            o.a("sendEvent switch：" + e.getMessage(), new Object[0]);
        }
        if (!z) {
            o.a("sendEvent unable url = " + str, new Object[0]);
            return;
        }
        try {
            com.qq.gdt.action.e.b.d().a(str).a(jSONObject.toString().getBytes()).b().b(bVar);
        } catch (Exception e2) {
            o.b("sendEvent 构建或发送请求失败：" + e2.getMessage(), e2);
            if (bVar != null) {
                bVar.b(e2);
            }
        }
    }

    private static void a(List<com.qq.gdt.action.f.a.a> list) {
        if (list != null) {
            try {
                if (list.size() > 0) {
                    a(list, true, new com.qq.gdt.action.e.a.b() { // from class: com.qq.gdt.action.h.a.1
                        @Override // com.qq.gdt.action.e.a.a
                        public void a(int i, com.qq.gdt.action.e.a aVar) {
                            o.a("reportEvents onSuccess statusCode = " + i + " dp3Response = " + aVar.toString(), new Object[0]);
                        }

                        @Override // com.qq.gdt.action.e.a.a
                        public void b(Throwable th) {
                            o.a("reportEvents onFail e = " + th, new Object[0]);
                        }
                    });
                }
            } catch (Throwable th) {
                o.b("reportEvents e = ", th);
            }
        }
    }

    private static void a(JSONObject jSONObject) throws Exception {
        if (com.qq.gdt.action.b.a(d.a().g()).r() != 0) {
            return;
        }
        jSONObject.putOpt(PluginConstants.KEY_SDK_VERSION, e.a());
        jSONObject.putOpt("user_action_set_id", d.a().h());
        jSONObject.putOpt("channel", d.a().q());
        jSONObject.putOpt(URLPackage.KEY_CHANNEL_ID, d.a().r());
        jSONObject.putOpt("user_unique_id", d.a().t());
        jSONObject.putOpt("sessionId", d.a().l());
        jSONObject.putOpt("sdk_name", "android_sdk");
    }

    public static boolean a(List<com.qq.gdt.action.f.a.a> list, boolean z, com.qq.gdt.action.e.a.b bVar) {
        if (list != null && list.size() != 0 && (z || com.qq.gdt.action.b.a(d.a().g()).d())) {
            try {
                JSONObject jSONObject = new JSONObject();
                jSONObject.putOpt("bid", 10021014);
                h.b();
                jSONObject.putOpt("device_id", d.a().o());
                try {
                    jSONObject.putOpt("privacyAgree", com.qq.gdt.action.multioprocess.d.a().f3099a.g());
                } catch (Throwable th) {
                    jSONObject.putOpt("privacyAgree", "privacy_unknow");
                    o.a("get privacy_agree ", th);
                }
                a(jSONObject);
                JSONArray jSONArray = new JSONArray();
                HashSet hashSet = new HashSet();
                for (com.qq.gdt.action.f.a.a aVar : list) {
                    if (aVar != null) {
                        hashSet.add(Long.valueOf(aVar.b()));
                    }
                    JSONObject jSONObjectB = b(aVar);
                    if (jSONObjectB != null) {
                        jSONArray.put(jSONObjectB);
                    }
                }
                JSONArray jSONArray2 = new JSONArray();
                Iterator it = hashSet.iterator();
                while (it.hasNext()) {
                    jSONArray2.put((Long) it.next());
                }
                jSONObject.putOpt("log_type", jSONArray2.toString());
                jSONObject.putOpt("body", jSONArray.toString());
                o.a("Dp3Service 上报数据：\n" + n.a(jSONObject.toString()), new Object[0]);
                a(p.c() ? "https://api.datanexus.qq.com/data-nexus-trace/log" : "http://api.datanexus.qq.com/data-nexus-trace/log", jSONObject, bVar);
                return true;
            } catch (Exception e) {
                o.a("Dp3Service 处理Dp3请求时发生错误：" + e.getMessage(), new Object[0]);
            }
        }
        return false;
    }

    private static JSONObject b(com.qq.gdt.action.f.a.a aVar) throws JSONException {
        if (aVar == null) {
            return null;
        }
        if (aVar.b() < 0) {
            o.b("Eventid must not be empty.");
            return null;
        }
        JSONObject jSONObject = new JSONObject();
        jSONObject.putOpt("eventId", Long.valueOf(aVar.b()));
        jSONObject.putOpt("curSessionId", aVar.c());
        jSONObject.putOpt("actionType", aVar.f());
        jSONObject.putOpt("actionTime", Long.valueOf(aVar.g()));
        jSONObject.putOpt("action_id", aVar.e());
        JSONObject jSONObjectH = aVar.h();
        if (jSONObjectH != null) {
            if (jSONObjectH.has(MediationConstant.KEY_ERROR_CODE)) {
                jSONObject.putOpt(MediationConstant.KEY_ERROR_CODE, jSONObjectH.opt(MediationConstant.KEY_ERROR_CODE));
            }
            if (jSONObjectH.has(MediationConstant.KEY_ERROR_MSG)) {
                jSONObject.putOpt(MediationConstant.KEY_ERROR_MSG, jSONObjectH.opt(MediationConstant.KEY_ERROR_MSG));
            }
            if (jSONObjectH.has("httpStatus")) {
                jSONObject.putOpt("httpStatus", jSONObjectH.opt("httpStatus"));
            }
        }
        return jSONObject;
    }
}
