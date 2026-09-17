package com.byazt.hy;

import android.text.TextUtils;
import com.byazt.aas.nb;
import com.byazt.ete.bm;
import com.byazt.ete.ic;
import com.byazt.ete.pu;
import com.byazt.nr.m;
import com.byazt.omf.gt;
import com.byazt.omf.gu;
import com.byazt.xs.sp;
import com.bykv.vk.component.ttvideo.player.MediaPlayer;
import java.io.IOException;
import java.util.Iterator;
import org.json.JSONException;
import org.json.JSONObject;

/* JADX INFO: loaded from: classes.dex */
@com.byazt.zqa.c(c = {0, 1, MediaPlayer.MEDIA_PLAYER_OPTION_BASEPLAYER_VIDEO_BUFLEN, 13})
public class tt {

    public interface c {
        void c(int i, String str);

        void c(JSONObject jSONObject);
    }

    /* JADX INFO: renamed from: com.byazt.hy.tt$tt, reason: collision with other inner class name */
    public interface InterfaceC0148tt {
        void c();

        void c(JSONObject jSONObject);
    }

    public static void c(com.byazt.seg.c cVar, InterfaceC0148tt interfaceC0148tt) {
        if (cVar != null) {
            c(cVar.ve(), cVar.c(), cVar.tt(), interfaceC0148tt);
        } else if (interfaceC0148tt != null) {
            interfaceC0148tt.c();
        }
    }

    public static void c(String str, final String str2, final String str3, final InterfaceC0148tt interfaceC0148tt) {
        if (TextUtils.isEmpty(str)) {
            if (interfaceC0148tt != null) {
                interfaceC0148tt.c();
            }
        } else {
            com.byazt.va.ve veVarVe = n.c().tt().ve();
            veVarVe.c(str);
            veVarVe.c(new com.byazt.mh.c() { // from class: com.byazt.hy.tt.1
                @Override // com.byazt.mh.c
                public void c(com.byazt.va.uj ujVar, com.byazt.hm.tt ttVar) {
                    if (ttVar == null) {
                        return;
                    }
                    if (ttVar.i()) {
                        String strN = ttVar.n();
                        sp.c().c(str2, str3, strN);
                        if (interfaceC0148tt != null) {
                            try {
                                interfaceC0148tt.c(new JSONObject(strN));
                                return;
                            } catch (JSONException e) {
                                m.c(e);
                                interfaceC0148tt.c();
                                return;
                            }
                        }
                        return;
                    }
                    InterfaceC0148tt interfaceC0148tt2 = interfaceC0148tt;
                    if (interfaceC0148tt2 != null) {
                        interfaceC0148tt2.c();
                    }
                }

                @Override // com.byazt.mh.c
                public void c(com.byazt.va.uj ujVar, IOException iOException) {
                    InterfaceC0148tt interfaceC0148tt2 = interfaceC0148tt;
                    if (interfaceC0148tt2 != null) {
                        interfaceC0148tt2.c();
                    }
                }
            });
        }
    }

    public static void c(ic icVar, JSONObject jSONObject, final com.byazt.at.uj ujVar, com.byazt.dj.tt ttVar) {
        if (ujVar == null) {
            return;
        }
        if (icVar != null) {
            try {
                if (!TextUtils.isEmpty(icVar.w_())) {
                    int iSl = nb.sl(icVar);
                    com.byazt.dj.tt ttVarIj = icVar.ij();
                    if (ttVarIj != null) {
                        ttVar = ttVarIj;
                    }
                    bm bmVar = new bm();
                    bmVar.n = 2;
                    if (pu.a(icVar) != null) {
                        bmVar.sp = 2;
                    }
                    JSONObject jSONObjectJm = icVar.jm();
                    JSONObject jSONObject2 = new JSONObject();
                    if (jSONObjectJm != null) {
                        try {
                            Iterator<String> itKeys = jSONObjectJm.keys();
                            while (itKeys.hasNext()) {
                                String next = itKeys.next();
                                jSONObject2.put(next, jSONObjectJm.opt(next));
                            }
                        } catch (JSONException e) {
                            m.c(e);
                        }
                    }
                    if (jSONObject != null) {
                        Iterator<String> itKeys2 = jSONObject.keys();
                        while (itKeys2.hasNext()) {
                            String next2 = itKeys2.next();
                            jSONObject2.put(next2, jSONObject.opt(next2));
                        }
                    }
                    bmVar.u = jSONObject2;
                    gt.c().c(ttVar, bmVar, iSl, new gu.tt() { // from class: com.byazt.hy.tt.2
                        @Override // com.byazt.omf.gu.tt
                        public void c(int i, String str, com.byazt.ete.tt ttVar2) {
                            ujVar.c(false, null, false);
                            ttVar2.c(i);
                            com.byazt.ete.tt.c(ttVar2);
                        }

                        @Override // com.byazt.omf.gu.tt
                        public void c(com.byazt.ete.c cVar, com.byazt.ete.tt ttVar2) {
                            if (cVar.tt() != null && !cVar.tt().isEmpty()) {
                                ujVar.c(true, cVar.tt(), false);
                                return;
                            }
                            ujVar.c(false, null, false);
                            ttVar2.c(-3);
                            com.byazt.ete.tt.c(ttVar2);
                        }
                    });
                    return;
                }
            } catch (Exception e2) {
                m.ve("PageNetUtils", "get ads error", e2);
                return;
            }
        }
        ujVar.c(false, null, false);
    }

    public static void c(String str, final c cVar) {
        com.byazt.va.ve veVarVe = n.c().tt().ve();
        veVarVe.c(str);
        veVarVe.c(new com.byazt.mh.c() { // from class: com.byazt.hy.tt.3
            @Override // com.byazt.mh.c
            public void c(com.byazt.va.uj ujVar, com.byazt.hm.tt ttVar) {
                if (ttVar != null && ttVar.i()) {
                    try {
                        JSONObject jSONObject = new JSONObject(ttVar.n());
                        c cVar2 = cVar;
                        if (cVar2 != null) {
                            cVar2.c(jSONObject);
                            return;
                        }
                        return;
                    } catch (JSONException e) {
                        m.c(e);
                        return;
                    }
                }
                c cVar3 = cVar;
                if (cVar3 == null || ttVar == null) {
                    return;
                }
                cVar3.c(ttVar.tt(), ttVar.ve());
            }

            @Override // com.byazt.mh.c
            public void c(com.byazt.va.uj ujVar, IOException iOException) {
                c cVar2 = cVar;
                if (cVar2 != null) {
                    cVar2.c(MediaPlayer.MEDIA_PLAYER_OPTION_ABR_DOWNLOAD_VIDEO_BITRATE, iOException.getMessage());
                }
            }
        });
    }
}
