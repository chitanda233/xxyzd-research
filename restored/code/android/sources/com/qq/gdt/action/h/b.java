package com.qq.gdt.action.h;

import cn.com.chinatelecom.account.api.utils.Constants;
import com.byazt.nys.PluginConstants;
import com.bykv.vk.component.ttvideo.player.MediaPlayer;
import com.qq.gdt.action.d;
import com.qq.gdt.action.e;
import com.qq.gdt.action.e.b.i;
import com.qq.gdt.action.e.f;
import com.qq.gdt.action.i.l;
import com.qq.gdt.action.i.n;
import com.qq.gdt.action.i.o;
import com.qq.gdt.action.i.p;
import com.qq.gdt.action.i.u;
import com.qq.gdt.action.i.v;
import java.io.IOException;
import javax.crypto.SecretKey;
import org.json.JSONException;
import org.json.JSONObject;

/* JADX INFO: loaded from: classes3.dex */
public class b {
    public static f a() {
        String str = p.b() ? "https://a.gdt.qq.com/getSdkConf" : "http://a.gdt.qq.com/getSdkConf";
        try {
            JSONObject jSONObjectB = b();
            SecretKey secretKeyJ = d.a().j();
            o.a("LaunchService#launch 加密前\n" + n.a(jSONObjectB.toString()), new Object[0]);
            String strA = a(jSONObjectB, secretKeyJ);
            JSONObject jSONObject = new JSONObject();
            jSONObject.putOpt("data", strA);
            jSONObject.putOpt("os", Constants.LOG_OS);
            jSONObject.putOpt("sdkv", e.a());
            jSONObject.putOpt("sdkvc", Integer.valueOf(e.b()));
            o.a("LaunchService#launch 正式请求\n" + n.a(jSONObject.toString()), new Object[0]);
            i iVarA = com.qq.gdt.action.e.b.d().a(str).a(jSONObject.toString().getBytes()).b().a();
            f fVar = new f(-1, "Unknown message", "");
            if (iVarA != null) {
                try {
                    JSONObject jSONObject2 = new JSONObject(iVarA.e().b());
                    fVar.a(jSONObject2.optInt(PluginConstants.KEY_ERROR_CODE, -3));
                    fVar.a(jSONObject2.optString("message", "Deserialize message error"));
                    if (jSONObject2.has("data")) {
                        JSONObject jSONObject3 = jSONObject2.getJSONObject("data");
                        if (jSONObject3.has("conf")) {
                            com.qq.gdt.action.b.a(d.a().g()).a(jSONObject3.getJSONObject("conf"));
                        }
                    }
                } catch (IOException | JSONException unused) {
                    o.a("Deserialize service response error", new Object[0]);
                    fVar.a(-3);
                    fVar.a("Deserialize service response error");
                }
            }
            return fVar;
        } catch (Throwable th) {
            o.b(v.a("LaunchService launch(%s) exception", str), th);
            return null;
        }
    }

    public static String a(JSONObject jSONObject, SecretKey secretKey) throws Exception {
        byte[] bArrB = com.qq.gdt.action.i.a.b(secretKey, jSONObject.toString().getBytes());
        byte[] bArr = new byte[48];
        System.arraycopy(u.b(bArrB), 0, bArr, 0, 16);
        System.arraycopy(secretKey.getEncoded(), 0, bArr, 16, 32);
        byte[] bArrA = l.a(bArr);
        byte[] bArr2 = new byte[bArrB.length + MediaPlayer.MEDIA_PLAYER_OPTION_DEFAULT_VIDEO_BITRATE];
        System.arraycopy(new byte[]{0, 1}, 0, bArr2, 0, 2);
        System.arraycopy(bArrA, 0, bArr2, 2, 128);
        System.arraycopy(bArrB, 0, bArr2, MediaPlayer.MEDIA_PLAYER_OPTION_DEFAULT_VIDEO_BITRATE, bArrB.length);
        return com.qq.gdt.action.i.i.a(bArr2);
    }

    private static JSONObject b() {
        JSONObject jSONObject = new JSONObject();
        try {
            jSONObject.putOpt("did", d.a().o());
            jSONObject.putOpt("sdkv", e.a());
            jSONObject.putOpt("asid", d.a().h());
            jSONObject.putOpt("conf_version", com.qq.gdt.action.b.a(d.a().g()).a());
        } catch (JSONException e) {
            o.b("Json Exception while build init req", e);
        }
        return jSONObject;
    }
}
