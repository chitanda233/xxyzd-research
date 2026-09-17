package com.sigmob.sdk.nativead;

import com.czhj.sdk.common.ClientMetadata;
import com.czhj.sdk.logger.SigmobLog;
import com.sigmob.sdk.base.models.BaseAdUnit;
import com.sigmob.sdk.base.models.ClickCommon;
import com.sigmob.sdk.base.models.SigMacroCommon;
import com.sigmob.sdk.base.mta.PointCategory;
import java.util.HashMap;

/* JADX INFO: loaded from: classes4.dex */
public class h extends com.sigmob.sdk.base.common.l {
    /* JADX WARN: Can't fix incorrect switch cases order, some code will duplicate */
    /* JADX WARN: Code duplicated, block: B:49:0x00a8  */
    @Override // com.sigmob.sdk.base.common.u
    public boolean a(BaseAdUnit adUnit, String event, int currentPosition) {
        String str;
        String str2;
        try {
            switch (event) {
                case "start":
                    com.sigmob.sdk.base.network.h.a(adUnit, event);
                    a(adUnit, event, (String) null, (HashMap<String, String>) null);
                    break;
                case "ad_show":
                    com.sigmob.sdk.base.network.h.a(adUnit, event);
                    a(adUnit, "ad_show", (String) null, (HashMap<String, String>) null);
                    break;
                case "ad_hide":
                    com.sigmob.sdk.base.network.h.a(adUnit, event);
                    a(adUnit, event, (String) null, (HashMap<String, String>) null);
                    break;
                case "video_link":
                    a(adUnit, event, true, "video_link");
                    break;
                case "video_restart":
                    a(adUnit, event, false, "video_restart");
                    break;
                case "video_start":
                    a(adUnit, event, false, "video_start");
                    break;
                case "video_pause":
                    a(adUnit, event, true, "video_pause");
                    break;
                case "play_quarter":
                    com.sigmob.sdk.base.network.h.a(adUnit, event);
                    str = "0.25";
                    a(adUnit, PointCategory.PLAY, str, (HashMap<String, String>) null);
                    break;
                case "play_two_quarters":
                    com.sigmob.sdk.base.network.h.a(adUnit, event);
                    str = "0.50";
                    a(adUnit, PointCategory.PLAY, str, (HashMap<String, String>) null);
                    break;
                case "play_three_quarters":
                    com.sigmob.sdk.base.network.h.a(adUnit, event);
                    str = "0.75";
                    a(adUnit, PointCategory.PLAY, str, (HashMap<String, String>) null);
                    break;
                case "complete":
                    a(adUnit, event, true, "complete");
                    break;
                case "click":
                    ClickCommon clickCommon = adUnit.getClickCommon();
                    String str3 = clickCommon.is_final_click ? "1" : "0";
                    SigMacroCommon macroCommon = adUnit.getMacroCommon();
                    macroCommon.addMarcoKey(SigMacroCommon._SLD_, clickCommon.sld);
                    macroCommon.addMarcoKey("_AX_", clickCommon.adarea_x);
                    macroCommon.addMarcoKey("_AY_", clickCommon.adarea_y);
                    macroCommon.addMarcoKey("_AW_", clickCommon.adarea_w);
                    macroCommon.addMarcoKey("_AH_", clickCommon.adarea_h);
                    if ("5".equals(clickCommon.sld)) {
                        macroCommon.updateClickMarco(SigMacroCommon.DEFAULT_XY, SigMacroCommon.DEFAULT_XY, SigMacroCommon.DEFAULT_XY, SigMacroCommon.DEFAULT_XY);
                        macroCommon.addMarcoKey("_TURNX_", clickCommon.turn_x);
                        macroCommon.addMarcoKey("_TURNY_", clickCommon.turn_y);
                        macroCommon.addMarcoKey("_TURNZ_", clickCommon.turn_z);
                        macroCommon.addMarcoKey("_TURNTIME_", clickCommon.turn_time);
                        macroCommon.addMarcoKey("_CPTIDS_", String.valueOf(clickCommon.widget_id));
                    } else if ("2".equals(clickCommon.sld)) {
                        macroCommon.updateClickMarco(SigMacroCommon.DEFAULT_XY, SigMacroCommon.DEFAULT_XY, SigMacroCommon.DEFAULT_XY, SigMacroCommon.DEFAULT_XY);
                        macroCommon.addMarcoKey("_CPTIDS_", String.valueOf(clickCommon.widget_id));
                        macroCommon.addMarcoKey("_XMAXACC_", clickCommon.x_max_acc);
                        macroCommon.addMarcoKey("_YMAXACC_", clickCommon.y_max_acc);
                        macroCommon.addMarcoKey("_ZMAXACC_", clickCommon.z_max_acc);
                    } else {
                        macroCommon.updateClickMarco(clickCommon.down, clickCommon.up);
                    }
                    String str4 = clickCommon.click_area;
                    macroCommon.addMarcoKey(SigMacroCommon._TEMPLATE_, String.valueOf(adUnit.getTemplateId()));
                    macroCommon.addMarcoKey(SigMacroCommon._CLICKAREA_, String.valueOf(str4));
                    macroCommon.addMarcoKey(SigMacroCommon._CLICKSCENE_, String.valueOf(clickCommon.click_scene));
                    macroCommon.addMarcoKey(SigMacroCommon._FINALCLICK_, str3);
                    if (com.sigmob.sdk.base.utils.s.a((CharSequence) str4, (CharSequence) "appinfo")) {
                        SigmobLog.d(this.f3185a + "recordDisplayEvent: Do Not Track");
                    } else {
                        SigmobLog.d(this.f3185a + "recordDisplayEvent: Track");
                        com.sigmob.sdk.base.network.h.a(adUnit, event);
                    }
                    HashMap<String, String> map = new HashMap<>();
                    map.put("template_id", clickCommon.template_id);
                    map.put("sld", clickCommon.sld);
                    map.put("adarea_x", clickCommon.adarea_x);
                    map.put("adarea_y", clickCommon.adarea_y);
                    map.put("adarea_w", clickCommon.adarea_w);
                    map.put("adarea_h", clickCommon.adarea_h);
                    if ("5".equals(clickCommon.sld)) {
                        map.put("turn_x", clickCommon.turn_x);
                        map.put("turn_y", clickCommon.turn_y);
                        map.put("turn_z", clickCommon.turn_z);
                        map.put("cpt_id", String.valueOf(clickCommon.widget_id));
                        map.put("turn_time", clickCommon.turn_time);
                    } else if ("2".equals(clickCommon.sld)) {
                        map.put("x_max_acc", clickCommon.x_max_acc);
                        map.put("y_max_acc", clickCommon.y_max_acc);
                        map.put("z_max_acc", clickCommon.z_max_acc);
                        map.put("cpt_id", String.valueOf(clickCommon.widget_id));
                    }
                    map.put(ClickCommon.CLICK_AREA, str4);
                    map.put("click_scene", clickCommon.click_scene);
                    map.put("cwidth", String.valueOf(ClientMetadata.getInstance().getDeviceScreenRealWidthDip()));
                    map.put("cheight", String.valueOf(ClientMetadata.getInstance().getDeviceScreenRealHeightDip()));
                    map.put("is_final_click", str3);
                    map.put("coordinate", macroCommon.getCoordinate());
                    map.put(ClickCommon.CLICK_LOSE_RATE, String.valueOf(clickCommon.click_lose_rate));
                    map.put(ClickCommon.CLICK_CB_STATE, String.valueOf(clickCommon.click_cb_state));
                    if (com.sigmob.sdk.base.utils.v.b(clickCommon.aim)) {
                        map.put(ClickCommon.AIM, String.valueOf(clickCommon.aim));
                        clickCommon.aim = null;
                    }
                    if (com.sigmob.sdk.base.utils.v.b(clickCommon.cpt_render_type)) {
                        map.put(ClickCommon.CPT_RENDER_TYPE, String.valueOf(clickCommon.cpt_render_type));
                        clickCommon.cpt_render_type = null;
                    }
                    a(adUnit, clickCommon.click_scene, "click", map);
                    break;
                case "fourElements_show":
                    str2 = "show";
                    a(adUnit, PointCategory.FOURELEMENTS, str2, (HashMap<String, String>) null);
                    break;
                case "fourElements_close":
                    str2 = "close";
                    a(adUnit, PointCategory.FOURELEMENTS, str2, (HashMap<String, String>) null);
                    break;
            }
        } catch (Throwable th) {
            SigmobLog.e(this.f3185a + "recordDisplayEvent: error = " + th.getMessage());
        }
        return true;
    }

    @Override // com.sigmob.sdk.base.common.u
    public boolean b(BaseAdUnit adUnit) {
        return true;
    }
}
