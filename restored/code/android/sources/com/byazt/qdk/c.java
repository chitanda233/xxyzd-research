package com.byazt.qdk;

import android.app.Dialog;
import android.content.Context;
import android.text.TextUtils;
import android.view.View;
import com.byazt.aas.n;
import com.byazt.aas.nb;
import com.byazt.ete.ic;
import com.byazt.ete.ir;
import com.byazt.omf.gt;
import com.byazt.omf.rl;
import com.byazt.pm.a;
import com.byazt.sy.uj;
import com.byazt.sz.m;
import com.byazt.un.NativeVideoTsView;
import com.bytedance.sdk.openadsdk.core.activity.base.TTDelegateActivity;
import com.bytedance.sdk.openadsdk.mediation.MediationConstant;
import java.util.HashMap;
import java.util.Map;
import org.json.JSONArray;
import org.json.JSONException;
import org.json.JSONObject;

/* JADX INFO: loaded from: classes2.dex */
@com.byazt.zqa.c(c = {0, 1, 1262, 20})
public class c {
    public static volatile c c;

    private c() {
    }

    public static c c() {
        if (c == null) {
            synchronized (c.class) {
                if (c == null) {
                    c = new c();
                }
            }
        }
        return c;
    }

    public boolean c(m mVar, ic icVar, Context context, com.byazt.xj.ve veVar, JSONObject jSONObject, tt ttVar, Map<String, Object> map) {
        ve veVarC = ve.c(mVar, jSONObject, map);
        if (ttVar == null || !ttVar.c(veVarC.c(), veVar, veVarC)) {
            return c(veVarC, icVar, context, veVar, ttVar);
        }
        return true;
    }

    public boolean c(a.c cVar, ic icVar, Context context, com.byazt.xj.ve veVar, JSONObject jSONObject, tt ttVar, Map<String, Object> map) {
        ve veVarC = ve.c(cVar, jSONObject, map);
        veVarC.c("v3_trigger_name");
        if (ttVar == null || !ttVar.c(veVarC.c(), veVar, veVarC)) {
            return c(veVarC, icVar, context, veVar, ttVar);
        }
        return true;
    }

    private boolean c(ve veVar, ic icVar, Context context, com.byazt.xj.ve veVar2, tt ttVar) {
        String strC = veVar != null ? veVar.c() : "";
        strC.hashCode();
        boolean z = false;
        switch (strC) {
            case "openAppPermission":
                uj(icVar, context);
                break;
            case "stopHaptic":
                c(context);
                break;
            case "openCommonUrl":
                c(veVar, context);
                break;
            case "renderScene":
                c(veVar, veVar2, icVar);
                break;
            case "openAppRegistration":
                a(icVar, context);
                break;
            case "openNewAdPage":
                c(veVar, icVar, context);
                break;
            case "haptic":
            case "playHaptic":
                c(veVar, context, icVar);
                break;
            case "uchain":
                tt(veVar, icVar, context);
                break;
            case "execEffect":
                c(veVar, veVar2);
                break;
            case "clickEvent":
            case "convert":
                c(veVar2, icVar, context);
                break;
            case "openPrivacy":
            case "openPolicy":
                tt(icVar, context);
                break;
            case "openAppFunctionDesc":
            case "openAppFunction":
                n(icVar, context);
                break;
            case "ugen_view_visibility_tracker":
                c(veVar, icVar);
                break;
            case "dismissScene":
                tt(veVar2);
                break;
            case "muteVideo":
                c(icVar);
                break;
            case "openAppPolicy":
                ve(icVar, context);
                break;
            case "dislike":
                c(icVar, context);
                break;
            case "dismiss":
                c(veVar2);
                break;
            default:
                if (z && ttVar != null) {
                    ttVar.c(strC);
                }
                return z;
        }
        z = true;
        if (z) {
            ttVar.c(strC);
        }
        return z;
    }

    private void c(com.byazt.xj.ve veVar, ic icVar, Context context) {
        com.byazt.oit.c.c(veVar != null ? veVar.i() : null, icVar, context);
    }

    private void c(ic icVar) {
        NativeVideoTsView nativeVideoTsView;
        if (icVar == null || (nativeVideoTsView = (NativeVideoTsView) rl.ve(icVar.lw(), NativeVideoTsView.class)) == null) {
            return;
        }
        boolean z = !nativeVideoTsView.m();
        nativeVideoTsView.tt(z, true);
        nativeVideoTsView.setIsQuiet(z);
    }

    private void c(ic icVar, Context context) {
        if (icVar == null) {
            return;
        }
        Dialog dialog = (Dialog) rl.ve(icVar.lw(), Dialog.class);
        com.byazt.dyf.tt ttVar = (com.byazt.dyf.tt) rl.ve(icVar.lw(), com.byazt.dyf.tt.class);
        if (dialog != null) {
            dialog.show();
        } else if (ttVar != null) {
            ttVar.showDislikeDialog();
        } else {
            TTDelegateActivity.c(context, icVar);
        }
    }

    private void c(com.byazt.xj.ve veVar) {
        if (veVar == null) {
            return;
        }
        uj.uj(veVar.i());
    }

    private void tt(ic icVar, Context context) {
        if (icVar == null || context == null) {
            return;
        }
        n.c(context, icVar);
    }

    private void ve(ic icVar, Context context) {
        if (icVar == null || context == null) {
            return;
        }
        n.tt(icVar, context, nb.tt(icVar));
    }

    private void uj(ic icVar, Context context) {
        if (icVar == null || context == null) {
            return;
        }
        n.ve(icVar, context, nb.tt(icVar));
    }

    private void n(ic icVar, Context context) {
        if (icVar == null || context == null) {
            return;
        }
        n.c(context, icVar, nb.tt(icVar));
    }

    private void a(ic icVar, Context context) {
        if (icVar == null || context == null) {
            return;
        }
        n.c(icVar, context, nb.tt(icVar));
    }

    private void c(ve veVar, Context context) {
        if (veVar == null) {
            return;
        }
        String strC = veVar.c("webUrl");
        String strC2 = veVar.c("webTitle");
        if (TextUtils.isEmpty(strC)) {
            return;
        }
        TTDelegateActivity.uj(context, strC, strC2);
    }

    private void c(ve veVar, Context context, ic icVar) {
        if (veVar == null) {
            return;
        }
        JSONObject jSONObjectTt = veVar.tt("params");
        String strC = veVar.c("id");
        JSONArray jSONArrayVe = veVar.ve("pattern");
        if (jSONObjectTt != null) {
            com.byazt.fx.ve.c(jSONObjectTt, context, icVar);
        } else {
            com.byazt.fx.ve.c(strC, jSONArrayVe, context, icVar);
        }
    }

    private void c(Context context) {
        if (context == null) {
            context = gt.getContext();
        }
        if (context == null) {
            return;
        }
        com.byazt.fx.ve.tt(context);
    }

    private void c(ve veVar, com.byazt.xj.ve veVar2) {
        com.byazt.xj.ve veVarTt;
        if (veVar == null || veVar2 == null) {
            return;
        }
        String strC = veVar.c("id");
        int iC = veVar.c("col", 4);
        int iC2 = veVar.c("row", 3);
        int iC3 = veVar.c(MediationConstant.EXTRA_DURATION, 600);
        if (TextUtils.isEmpty(strC) || (veVarTt = veVar2.tt(veVar2)) == null) {
            return;
        }
        com.byazt.xj.ve veVarUj = veVarTt.uj(strC);
        if (veVarUj instanceof com.byazt.yn.c) {
            ((com.byazt.yn.c) veVarUj).c(iC, iC2, iC3);
        }
    }

    private void c(ve veVar, com.byazt.xj.ve veVar2, ic icVar) {
        View viewI;
        ir irVarC;
        if (veVar == null || veVar2 == null) {
            return;
        }
        String strC = veVar.c("scene");
        String strC2 = veVar.c("ugen_id");
        String strC3 = veVar.c("ugen_md5");
        String strC4 = veVar.c("ugen_url");
        int iC = veVar.c("displayAreaAndroid", 0);
        int iC2 = veVar.c("render_sequence", 2);
        if (!TextUtils.equals("scene1", strC) || !uj.c(iC) || (viewI = veVar2.i()) == null || icVar == null || (irVarC = uj.c(strC2, strC3, strC4, iC, iC2, 5)) == null || !irVarC.t()) {
            return;
        }
        new com.byazt.ma.n(icVar, null, irVarC).c(viewI);
    }

    private void tt(com.byazt.xj.ve veVar) {
        uj.c(veVar.i(), "fullscreen_tag");
    }

    private void c(ve veVar, ic icVar, Context context) {
        if (veVar == null || icVar == null) {
            return;
        }
        new com.byazt.rob.c(icVar, context).c(veVar.c("second_page_type", 0), icVar.ij());
    }

    private void tt(ve veVar, ic icVar, Context context) {
        HashMap map = new HashMap();
        map.put("material_meta", icVar);
        map.put("context", context);
        map.put("event_tag", nb.tt(icVar));
        com.byazt.ppf.ve.c(icVar, (HashMap<String, Object>) map, veVar);
    }

    private void c(ve veVar, ic icVar) {
        if (veVar == null || icVar == null) {
            return;
        }
        JSONObject jSONObject = new JSONObject();
        try {
            for (String str : veVar.tt().keySet()) {
                jSONObject.put(str, veVar.c(str));
            }
        } catch (JSONException unused) {
        }
        HashMap map = new HashMap();
        HashMap map2 = new HashMap();
        map2.put("material_meta", icVar);
        HashMap map3 = new HashMap();
        map3.put("ugen_event_params", jSONObject);
        String strTt = nb.tt(icVar);
        nb.md();
        com.byazt.ppf.ve.c(icVar, map, "ugen_view_visibility_tracker", map2, strTt, map3, -1L);
    }
}
