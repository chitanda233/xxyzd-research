package cn.thinkingdata.analytics.encrypt;

import android.text.TextUtils;
import cn.thinkingdata.analytics.TDConfig;
import java.util.ArrayList;
import java.util.HashMap;
import java.util.List;
import java.util.Map;
import org.json.JSONObject;

/* JADX INFO: loaded from: classes.dex */
public class e {
    private static final Map<String, e> d = new HashMap();

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    private a f103a;
    private final List<a> b;
    private final TDConfig c;

    private e(TDConfig tDConfig) {
        ArrayList arrayList = new ArrayList();
        this.b = arrayList;
        this.c = tDConfig;
        arrayList.add(new d());
    }

    public static e a(String str) {
        e eVar;
        Map<String, e> map = d;
        synchronized (map) {
            eVar = map.get(str);
        }
        return eVar;
    }

    public static e a(String str, TDConfig tDConfig) {
        e eVar;
        Map<String, e> map = d;
        synchronized (map) {
            eVar = map.get(str);
            if (eVar == null) {
                eVar = new e(tDConfig);
                map.put(str, eVar);
            }
        }
        return eVar;
    }

    private boolean a(a aVar) {
        return TextUtils.isEmpty(aVar.b()) || TextUtils.isEmpty(aVar.a());
    }

    private boolean b(TDSecreteKey tDSecreteKey) {
        return tDSecreteKey == null || TextUtils.isEmpty(tDSecreteKey.publicKey);
    }

    a a(TDSecreteKey tDSecreteKey) {
        if (b(tDSecreteKey)) {
            return null;
        }
        for (a aVar : this.b) {
            if (aVar != null && a(aVar, tDSecreteKey)) {
                return aVar;
            }
        }
        return null;
    }

    public JSONObject a(JSONObject jSONObject) {
        try {
            TDConfig tDConfig = this.c;
            if (tDConfig == null) {
                return jSONObject;
            }
            TDSecreteKey secreteKey = tDConfig.getSecreteKey();
            if (b(secreteKey)) {
                return jSONObject;
            }
            if (!a(this.f103a, secreteKey)) {
                this.f103a = a(secreteKey);
            }
            if (this.f103a == null) {
                return jSONObject;
            }
            String strSubstring = secreteKey.publicKey;
            if (strSubstring.startsWith("EC:")) {
                strSubstring = strSubstring.substring(strSubstring.indexOf(":") + 1);
            }
            String strB = this.f103a.b(strSubstring);
            if (TextUtils.isEmpty(strB)) {
                return jSONObject;
            }
            String strA = this.f103a.a(jSONObject.toString());
            if (TextUtils.isEmpty(strA)) {
                return jSONObject;
            }
            JSONObject jSONObject2 = new JSONObject();
            jSONObject2.put("ekey", strB);
            jSONObject2.put("pkv", secreteKey.version);
            jSONObject2.put("payload", strA);
            return jSONObject2;
        } catch (Exception unused) {
            return jSONObject;
        }
    }

    boolean a(a aVar, TDSecreteKey tDSecreteKey) {
        return (aVar == null || b(tDSecreteKey) || a(aVar) || !aVar.b().equals(tDSecreteKey.asymmetricEncryption) || !aVar.a().equals(tDSecreteKey.symmetricEncryption)) ? false : true;
    }
}
