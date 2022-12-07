using System;

namespace AdventOfCode2022
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AoC7();
        }

        public static void AoC7()
        {
            bool IsSecondPart = true;
            int maxFileSize = 100000;
            int totalDiskSize = 70000000;
            int updateSize = 30000000;

            string input = @"$ cd /
$ ls
dir fnsvfbzt
dir hqdssf
dir jwphbz
dir lncqsmj
dir mhqs
dir trwqgzsb
132067 vjw
dir wbsph
$ cd fnsvfbzt
$ ls
62158 sfwnts.hbj
$ cd ..
$ cd hqdssf
$ ls
45626 cvcbmcm
dir dlsmjsbz
dir hqdssf
dir mhqs
dir mtw
dir sfccfsrd
dir shzgg
$ cd dlsmjsbz
$ ls
9205 qcqbgd.lzd
$ cd ..
$ cd hqdssf
$ ls
105963 mhqs.zrn
87909 slwshm.nwr
$ cd ..
$ cd mhqs
$ ls
dir ctfl
45923 jvvl.rcs
dir jzjm
dir lncqsmj
dir mhqs
dir wfbvtfmr
$ cd ctfl
$ ls
dir shzgg
$ cd shzgg
$ ls
18097 cvcbmcm
289064 mhqs
208557 slwshm.nwr
283449 vjw
dir wfbvtfmr
$ cd wfbvtfmr
$ ls
263560 dssbpgnl.szh
dir hnqjmq
76551 jvvl.rcs
195911 lncqsmj
185776 slwshm.nwr
$ cd hnqjmq
$ ls
3307 rjd.lgh
$ cd ..
$ cd ..
$ cd ..
$ cd ..
$ cd jzjm
$ ls
31719 rjjrg.pjq
$ cd ..
$ cd lncqsmj
$ ls
dir mhqs
$ cd mhqs
$ ls
138296 wfbvtfmr
$ cd ..
$ cd ..
$ cd mhqs
$ ls
175499 jvvl.rcs
dir rqznrr
108476 slwshm.nwr
199853 vjw
$ cd rqznrr
$ ls
105075 shslmlt.spg
$ cd ..
$ cd ..
$ cd wfbvtfmr
$ ls
131522 rjjrg.pjq
$ cd ..
$ cd ..
$ cd mtw
$ ls
dir dcgpfrsf
dir gwqm
188911 hqdssf
34693 jvvl.rcs
dir shzgg
$ cd dcgpfrsf
$ ls
47863 dfwthflp.jwq
203815 dqbqbps.prq
dir mhqs
183653 rqjqpm.bbr
220694 vjw
$ cd mhqs
$ ls
74450 tjpn
$ cd ..
$ cd ..
$ cd gwqm
$ ls
dir trghjhvs
$ cd trghjhvs
$ ls
dir shzgg
2620 slwshm.nwr
$ cd shzgg
$ ls
73435 shzgg.bbf
$ cd ..
$ cd ..
$ cd ..
$ cd shzgg
$ ls
184378 rjjrg.pjq
$ cd ..
$ cd ..
$ cd sfccfsrd
$ ls
87317 ccvs.phq
dir cqmgf
dir cssmfv
dir hhhqdmz
17971 mhqs
dir mvjttqr
264394 slwshm.nwr
dir stdzptb
dir tcddd
dir zmrt
dir zqqtb
$ cd cqmgf
$ ls
202804 tcrqqlgs
$ cd ..
$ cd cssmfv
$ ls
13440 jnhzrtfd
$ cd ..
$ cd hhhqdmz
$ ls
dir fdbpld
272827 jftd.lml
dir prqbhbv
dir wbzvmz
$ cd fdbpld
$ ls
dir bgrnz
dir dcdj
78284 jqqfc.tzz
147731 lbdsh.plp
269235 ntf.gmq
$ cd bgrnz
$ ls
dir qzs
dir rcv
dir wmrmhdd
$ cd qzs
$ ls
156779 lncqsmj.gnf
$ cd ..
$ cd rcv
$ ls
224927 dvbw.svf
dir hqdssf
dir jjmsqft
255189 mhqs.pcl
dir mvgqtlm
dir pjs
dir sljw
$ cd hqdssf
$ ls
63099 blpdwd
96035 jvvl.rcs
40533 lvpsmzw
205031 rjjrg.pjq
59874 shzgg.ldg
dir zdnfpwlw
$ cd zdnfpwlw
$ ls
109325 hqdssf.fmj
41775 jfqhq.tdn
203744 nprghch.zjb
dir qfs
dir rzctqrgm
dir shzgg
$ cd qfs
$ ls
234449 vjw
$ cd ..
$ cd rzctqrgm
$ ls
99041 cvcbmcm
$ cd ..
$ cd shzgg
$ ls
149752 mhqs.bds
126331 rjjrg.pjq
75464 vbcjqdjv
$ cd ..
$ cd ..
$ cd ..
$ cd jjmsqft
$ ls
47522 shzgg
$ cd ..
$ cd mvgqtlm
$ ls
dir tgtbj
dir tmrsn
dir vpv
$ cd tgtbj
$ ls
86585 lbmv.jcr
202755 rjjrg.pjq
$ cd ..
$ cd tmrsn
$ ls
150980 hqdssf.hmh
$ cd ..
$ cd vpv
$ ls
197783 jvvl.rcs
$ cd ..
$ cd ..
$ cd pjs
$ ls
216539 cvcbmcm
159509 jgfphj
195297 pdgnb.qjd
162974 rjjrg.pjq
$ cd ..
$ cd sljw
$ ls
61689 hqdssf.bbn
$ cd ..
$ cd ..
$ cd wmrmhdd
$ ls
92888 msgcqfbf
$ cd ..
$ cd ..
$ cd dcdj
$ ls
99280 mclcnw
$ cd ..
$ cd ..
$ cd prqbhbv
$ ls
102589 bqlcds.pqp
107625 mhqs
281871 mvwvdtd.dzf
$ cd ..
$ cd wbzvmz
$ ls
287371 tnwgfw
$ cd ..
$ cd ..
$ cd mvjttqr
$ ls
dir dtf
dir frcqdb
dir hqdssf
55645 slwshm.nwr
dir zdzchmtq
$ cd dtf
$ ls
121764 cvcbmcm
279094 lncqsmj
68484 slwshm.nwr
278387 vjw
$ cd ..
$ cd frcqdb
$ ls
233216 lncqsmj.mbd
217901 slwshm.nwr
$ cd ..
$ cd hqdssf
$ ls
dir dgdtm
260973 qnt
231311 thdrddd.zmj
160399 vjw
dir vpqjmmf
197241 vqvzsv.nzg
$ cd dgdtm
$ ls
dir cnshbf
173312 vjw
$ cd cnshbf
$ ls
72788 hqdssf.mhc
122945 rjjrg.pjq
$ cd ..
$ cd ..
$ cd vpqjmmf
$ ls
127969 hqdssf.stc
267724 lncqsmj
55890 mhqs.mql
dir tsbtz
$ cd tsbtz
$ ls
244065 qqfnbd.nqv
59649 qttbcgd.vtj
$ cd ..
$ cd ..
$ cd ..
$ cd zdzchmtq
$ ls
271886 lmphsmv
dir nncghrr
$ cd nncghrr
$ ls
180468 rjjrg.pjq
$ cd ..
$ cd ..
$ cd ..
$ cd stdzptb
$ ls
19398 frsztqqz.mnc
$ cd ..
$ cd tcddd
$ ls
dir hqdssf
71084 jvvl.rcs
dir wnzhld
$ cd hqdssf
$ ls
178907 gcslqrn
$ cd ..
$ cd wnzhld
$ ls
206073 hpdnj
$ cd ..
$ cd ..
$ cd zmrt
$ ls
dir bmfgjr
dir bpztq
dir chsh
dir dpjhn
288144 mhqs.zvb
$ cd bmfgjr
$ ls
189592 jhmgm
$ cd ..
$ cd bpztq
$ ls
184906 rjjrg.pjq
$ cd ..
$ cd chsh
$ ls
110753 jvvl.rcs
dir lncqsmj
dir njdgplj
dir qhpplfnd
190460 rjjrg.pjq
144668 wfbvtfmr.flv
$ cd lncqsmj
$ ls
dir pzd
$ cd pzd
$ ls
287833 vhfjdg.jrz
$ cd ..
$ cd ..
$ cd njdgplj
$ ls
dir cbvz
dir vfhj
$ cd cbvz
$ ls
dir rtpcsrf
$ cd rtpcsrf
$ ls
240018 wfbvtfmr
$ cd ..
$ cd ..
$ cd vfhj
$ ls
152840 cbbrgc.wnq
243656 hqdssf
36325 hqdssf.fhn
$ cd ..
$ cd ..
$ cd qhpplfnd
$ ls
206490 dfththnq.vnm
$ cd ..
$ cd ..
$ cd dpjhn
$ ls
127322 rjjrg.pjq
dir shzgg
$ cd shzgg
$ ls
165774 cvcbmcm
$ cd ..
$ cd ..
$ cd ..
$ cd zqqtb
$ ls
dir ljnmbqvd
60485 pcz.snl
274930 slwshm.nwr
131928 vqm
51341 wfbvtfmr.stc
$ cd ljnmbqvd
$ ls
268048 bdbjn
dir fjh
dir qpclpbz
dir rqpljw
dir tzjftf
255809 vjw
243604 wfbvtfmr.rzb
$ cd fjh
$ ls
180021 hqdssf.rqs
$ cd ..
$ cd qpclpbz
$ ls
109952 blmm.nsv
dir dltbt
dir htbzp
287761 mfbd
dir mhqs
dir vgbvrwvn
dir wmhd
$ cd dltbt
$ ls
205121 dfzlcv.hjf
56409 hpqhhmb.sss
233277 hqdssf.qcb
187838 mbmcfhf.fnj
dir rrqjn
dir swrgj
151306 tqjzq.dmg
$ cd rrqjn
$ ls
240447 lncqsmj
$ cd ..
$ cd swrgj
$ ls
dir lnnwdbt
dir sgjsn
dir wfbvtfmr
$ cd lnnwdbt
$ ls
213111 tnn.bhq
$ cd ..
$ cd sgjsn
$ ls
dir wpprqhs
$ cd wpprqhs
$ ls
dir hqdssf
$ cd hqdssf
$ ls
209286 qbdfzdzw.sgp
$ cd ..
$ cd ..
$ cd ..
$ cd wfbvtfmr
$ ls
199298 hqdssf.chs
123953 rjjrg.pjq
$ cd ..
$ cd ..
$ cd ..
$ cd htbzp
$ ls
dir bmfr
68162 bzwcswr.mlv
284074 dtzwf
270421 jpsvh.ncc
dir mwbvz
95631 shzgg.tbf
44434 vjw
$ cd bmfr
$ ls
19937 shzgg
$ cd ..
$ cd mwbvz
$ ls
156668 rjjrg.pjq
$ cd ..
$ cd ..
$ cd mhqs
$ ls
111821 ftrv.zcw
dir jsnlcn
dir mhqs
dir rjdwmb
dir sfmrwgd
$ cd jsnlcn
$ ls
7527 smqts.cnc
dir svdw
$ cd svdw
$ ls
173846 vjtrp
$ cd ..
$ cd ..
$ cd mhqs
$ ls
dir hswdjgg
30326 rjjrg.pjq
$ cd hswdjgg
$ ls
285037 jvvl.rcs
$ cd ..
$ cd ..
$ cd rjdwmb
$ ls
219498 twl.lmw
$ cd ..
$ cd sfmrwgd
$ ls
168290 ltwpm.fjl
$ cd ..
$ cd ..
$ cd vgbvrwvn
$ ls
dir bswv
dir hqdssf
dir mhqs
$ cd bswv
$ ls
121032 cncdt
dir jrbmlg
dir lncqsmj
dir mhmgn
65380 rjjrg.pjq
dir wfbvtfmr
$ cd jrbmlg
$ ls
37975 shzgg.bnq
$ cd ..
$ cd lncqsmj
$ ls
114558 jvvl.rcs
dir mhqs
dir nfn
dir nhlbfq
141816 phtt.phj
181530 vjw
224510 zmzp.jwg
$ cd mhqs
$ ls
dir wpnw
$ cd wpnw
$ ls
286077 lncqsmj.cld
$ cd ..
$ cd ..
$ cd nfn
$ ls
269740 cvcbmcm
87123 mhqs.nst
61029 mhqs.vhb
211712 slwshm.nwr
$ cd ..
$ cd nhlbfq
$ ls
247458 lncqsmj
$ cd ..
$ cd ..
$ cd mhmgn
$ ls
85806 vjw
$ cd ..
$ cd wfbvtfmr
$ ls
275888 cvvhvg.pwv
151703 gnbm
61419 grcfbwdp
150382 gzdmzj.wpc
dir mtrqcwrd
112827 nbtjlnt.srg
$ cd mtrqcwrd
$ ls
273564 shzgg.tbm
$ cd ..
$ cd ..
$ cd ..
$ cd hqdssf
$ ls
72227 ccvwdrs.dsf
141028 dctbz.spr
dir shzgg
277461 slwshm.nwr
94390 stgp.trm
24297 vgdzsrrl.dhg
$ cd shzgg
$ ls
143437 lncqsmj.vpl
78418 pbdwbmtd.nlp
28173 vlfj.tps
$ cd ..
$ cd ..
$ cd mhqs
$ ls
97312 jvvl.rcs
dir qqfbsz
42472 rjjrg.pjq
dir wfbvtfmr
$ cd qqfbsz
$ ls
dir lncqsmj
dir mhqs
$ cd lncqsmj
$ ls
186873 wfbvtfmr.lfh
$ cd ..
$ cd mhqs
$ ls
dir wfbvtfmr
$ cd wfbvtfmr
$ ls
234441 gsjwsn
$ cd ..
$ cd ..
$ cd ..
$ cd wfbvtfmr
$ ls
55214 dgf
dir fdtz
6756 jvvl.rcs
226995 rpsjvr.wpb
68993 vjw
$ cd fdtz
$ ls
dir rdzsjm
$ cd rdzsjm
$ ls
dir mjgfpvc
$ cd mjgfpvc
$ ls
dir vfcq
$ cd vfcq
$ ls
dir fmtfm
$ cd fmtfm
$ ls
200137 dvbqjq
$ cd ..
$ cd ..
$ cd ..
$ cd ..
$ cd ..
$ cd ..
$ cd ..
$ cd ..
$ cd wmhd
$ ls
dir hnn
dir rzt
$ cd hnn
$ ls
16335 wfbvtfmr.vhw
262909 zgtln.dwc
$ cd ..
$ cd rzt
$ ls
285086 mhqs.vsg
dir qnr
$ cd qnr
$ ls
290611 llnp.hsh
$ cd ..
$ cd ..
$ cd ..
$ cd ..
$ cd rqpljw
$ ls
267152 jbv
$ cd ..
$ cd tzjftf
$ ls
258707 cnfb.dgv
17087 hqdssf.dtd
92075 nwvtww
dir qblrnn
dir tdg
$ cd qblrnn
$ ls
dir brrqp
dir frqcc
25504 jvvl.rcs
dir lncqsmj
dir mhqs
107908 rjjrg.pjq
286918 rngbhp.ntg
dir shzgg
dir wcnh
dir wfbvtfmr
$ cd brrqp
$ ls
270783 wfbvtfmr
$ cd ..
$ cd frqcc
$ ls
dir clj
7502 lncqsmj
dir mnsbr
73859 scwltjwh.cqd
29920 vjw
dir wpplgrc
$ cd clj
$ ls
31407 grm.pwv
$ cd ..
$ cd mnsbr
$ ls
dir wfbvtfmr
99467 whsrtf.gff
$ cd wfbvtfmr
$ ls
81283 cvcbmcm
$ cd ..
$ cd ..
$ cd wpplgrc
$ ls
285496 lncqsmj.hwq
$ cd ..
$ cd ..
$ cd lncqsmj
$ ls
8972 jvvl.rcs
$ cd ..
$ cd mhqs
$ ls
119520 hqdssf.tbn
$ cd ..
$ cd shzgg
$ ls
180825 lncqsmj.rsg
23507 wfbvtfmr
$ cd ..
$ cd wcnh
$ ls
98662 tmwrh
220468 wml.sht
$ cd ..
$ cd wfbvtfmr
$ ls
283178 hqdssf.ctf
$ cd ..
$ cd ..
$ cd tdg
$ ls
283636 cvcbmcm
117742 gsqzjfn.pmp
176660 lncqsmj
dir pbdgbsts
dir znvv
$ cd pbdgbsts
$ ls
92092 vjw
$ cd ..
$ cd znvv
$ ls
41213 hqdssf.rnn
dir pcttrtd
$ cd pcttrtd
$ ls
16759 mhqs.gpb
$ cd ..
$ cd ..
$ cd ..
$ cd ..
$ cd ..
$ cd ..
$ cd ..
$ cd shzgg
$ ls
19544 bcn.rws
dir fqwpwcq
dir hngpzst
dir hqdssf
dir shzgg
dir vgjr
dir wfbvtfmr
$ cd fqwpwcq
$ ls
269576 mhqs
dir pmfv
$ cd pmfv
$ ls
175725 jvvl.rcs
29161 pnbm.mlr
$ cd ..
$ cd ..
$ cd hngpzst
$ ls
18430 cvcbmcm
dir fgzlgbm
dir hqdssf
378 rjjrg.pjq
dir zjlnsztt
$ cd fgzlgbm
$ ls
134751 dwlfbfjp
dir hqdssf
227313 jvvl.rcs
dir lncqsmj
dir mhqs
dir qfjmtvpv
dir qzm
114934 shzgg.jdf
187091 zpgbdnl.twq
$ cd hqdssf
$ ls
87131 bdmdpdf.cqg
dir fdc
dir gwgp
$ cd fdc
$ ls
116738 cvcbmcm
$ cd ..
$ cd gwgp
$ ls
dir qdvss
dir rpwzw
dir wfbvtfmr
$ cd qdvss
$ ls
111546 wqnsrnh
$ cd ..
$ cd rpwzw
$ ls
183614 lfjqvff
129803 rdwd
$ cd ..
$ cd wfbvtfmr
$ ls
266779 mhqs
189793 slwshm.nwr
279894 sncqtvwp.mff
40520 vjw
$ cd ..
$ cd ..
$ cd ..
$ cd lncqsmj
$ ls
257714 dtcjv.lsd
69877 shzgg
267645 vjw
$ cd ..
$ cd mhqs
$ ls
257031 stsfrb.gvs
$ cd ..
$ cd qfjmtvpv
$ ls
dir mhqs
$ cd mhqs
$ ls
91378 wldhvhl
$ cd ..
$ cd ..
$ cd qzm
$ ls
dir shn
$ cd shn
$ ls
dir jmmlsvdg
$ cd jmmlsvdg
$ ls
41383 rnlgl.vjv
$ cd ..
$ cd ..
$ cd ..
$ cd ..
$ cd hqdssf
$ ls
dir mzj
$ cd mzj
$ ls
169639 sgdn
$ cd ..
$ cd ..
$ cd zjlnsztt
$ ls
78315 jfj.sgg
$ cd ..
$ cd ..
$ cd hqdssf
$ ls
906 rjjrg.pjq
$ cd ..
$ cd shzgg
$ ls
163015 mhqs.cnb
$ cd ..
$ cd vgjr
$ ls
129546 hclg.vbl
286437 hqdssf
dir lncqsmj
1552 nhgwff
279693 qmpdlw
83645 slwshm.nwr
$ cd lncqsmj
$ ls
233355 fhpjbpjl.tbh
$ cd ..
$ cd ..
$ cd wfbvtfmr
$ ls
218452 jvvl.rcs
47525 rjjrg.pjq
109880 tctz.rnd
$ cd ..
$ cd ..
$ cd ..
$ cd jwphbz
$ ls
dir bqbwds
dir mwnzw
113414 qgdsgfg.ngj
141013 qtp
10795 slwshm.nwr
$ cd bqbwds
$ ls
18049 shzgg
$ cd ..
$ cd mwnzw
$ ls
169353 dtqlr
dir hlrgzlph
dir mhqs
238527 vjw
$ cd hlrgzlph
$ ls
249097 hqdssf
86490 pwdmzwb
$ cd ..
$ cd mhqs
$ ls
176337 rjjrg.pjq
$ cd ..
$ cd ..
$ cd ..
$ cd lncqsmj
$ ls
dir jmsw
dir mcgm
dir mpc
233050 rjjrg.pjq
30757 shzgg
250575 slwshm.nwr
$ cd jmsw
$ ls
dir hqdssf
dir nmsbdqhm
dir wfbvtfmr
$ cd hqdssf
$ ls
44806 lvzm
$ cd ..
$ cd nmsbdqhm
$ ls
dir czzp
dir gcp
dir gsrnmq
dir rmngvc
dir vpfq
dir vpzvb
dir wccgblsq
43981 wfbvtfmr
$ cd czzp
$ ls
95330 slwshm.nwr
82000 wfbvtfmr
$ cd ..
$ cd gcp
$ ls
229303 ddsppspd.fcn
$ cd ..
$ cd gsrnmq
$ ls
dir hrsstlt
dir rzc
40890 sfpt
$ cd hrsstlt
$ ls
18477 mnpc.tmh
$ cd ..
$ cd rzc
$ ls
33078 dmfwf
149792 wfbvtfmr.jnz
dir zsnmz
$ cd zsnmz
$ ls
dir gzsnl
69834 lplszs.rvg
213489 slwshm.nwr
dir vrnqh
$ cd gzsnl
$ ls
109060 jvvl.rcs
122307 svtppnvt.wrz
$ cd ..
$ cd vrnqh
$ ls
94389 jvvl.rcs
$ cd ..
$ cd ..
$ cd ..
$ cd ..
$ cd rmngvc
$ ls
dir jljbrrgg
$ cd jljbrrgg
$ ls
128554 cvcbmcm
$ cd ..
$ cd ..
$ cd vpfq
$ ls
73628 rjjrg.pjq
$ cd ..
$ cd vpzvb
$ ls
265609 rjjrg.pjq
$ cd ..
$ cd wccgblsq
$ ls
110134 hffzwm.zfr
$ cd ..
$ cd ..
$ cd wfbvtfmr
$ ls
209356 jvvl.rcs
286105 mtsb.bwd
234687 vcgnlc.cft
$ cd ..
$ cd ..
$ cd mcgm
$ ls
203407 cvcbmcm
$ cd ..
$ cd mpc
$ ls
dir shzgg
$ cd shzgg
$ ls
dir bnb
$ cd bnb
$ ls
232449 lncqsmj.czs
$ cd ..
$ cd ..
$ cd ..
$ cd ..
$ cd mhqs
$ ls
116955 jvvl.rcs
$ cd ..
$ cd trwqgzsb
$ ls
88439 jgphdrnq
$ cd ..
$ cd wbsph
$ ls
dir mhqs
dir vgh
$ cd mhqs
$ ls
133965 rfh.zdb
$ cd ..
$ cd vgh
$ ls
36092 rjjrg.pjq";
            string[] commands = input.Split("\r\n");

            Dictionary<string, int> directories = new Dictionary<string, int>();
            List<string> currentDirectories = new List<string>();

            foreach (var command in commands)
            {
                if (command.StartsWith("$ cd"))
                {
                    if (command.Contains(".."))
                    {
                        currentDirectories.RemoveAt(currentDirectories.Count - 1);
                    }
                    else
                    {
                        string dirPath = "";
                        if (currentDirectories.Count > 0)
                        {
                            dirPath = currentDirectories.Last();
                            dirPath += dirPath.EndsWith("/") ? "" : "/";
                        }
                        string currentDirectory = command.Split(" ").Last();
                        currentDirectories.Add(dirPath + currentDirectory);
                    }
                }
                else if (!command.StartsWith("$ ls") && !command.StartsWith("dir"))
                {
                    int filesize = int.Parse(command.Split(" ")[0]);
                    foreach (var directory in currentDirectories)
                    {
                        if (directories.ContainsKey(directory))
                        {
                            directories[directory] += filesize;
                        }
                        else
                        {
                            directories.Add(directory, filesize);
                        }
                    }
                }
            }

            int dirFileSize = 0;

            if (!IsSecondPart)
            {
                foreach (var directory in directories)
                {
                    if (directory.Value <= maxFileSize)
                    {
                        dirFileSize += directory.Value;
                    }
                }
            }
            else
            {
                int freeSpace = totalDiskSize - directories["/"];
                int spaceNeeded = updateSize - freeSpace;
                dirFileSize = int.MaxValue;
                foreach (var directory in directories)
                {
                    if (directory.Value >= spaceNeeded && directory.Value < dirFileSize)
                    {
                        dirFileSize = directory.Value;
                    }
                }
            }

            Console.WriteLine(dirFileSize);
        }

        public static void AoC6()
        {
            #region input
            string input = "hqhnqhqshhslswsffchfcfbblvlblqlggfwwqfwwqdddbbbhzhjjrqjqbjqjwqjwqwhwrrmcrrjqjjlllcvcrrnpptzpzmmswmmzrzjrrfcrfccpbpzzvrrdndllttwftwwgzzwhwggdvdnnlrnncscbcfcctchcdchdccztzgzjjtdtcdtcchrrgpgzgsgpsggvtvppdccfhcfclfcfdfnddlbbptbtdbtdtjdjgdjjzljlssgbgcgqcqzccfnftfjjsgstggsngsscvssjzjnjtntvnvssrqqhtqtvqtvvjbvvbnvvqvmvrmmdsdvdwwnbnvbnvvcgvcczcfzftfsfrfsfttldtdrrgrgmgbbdvvbqbhqbqlqsqbsbpbgbvgbgwwrswrwrwttvnnzdnzzwggrmrfmmvllzwlwzzlvlbvllgsllpnlnvncvcvqqrwwcmcczhchzczbccdwcwvwzwwvddlwlhljlqjqnncntnctczzmwmlmccpggljlssqswsmmpvmvwvrrcpcrprmprrtdrtdrrsjsmshmmdpdlppbnbvvmmflmmjvjhvhjvjsjbjwjvvblvbvlbbllwlslvljvlvdvdgvgcchnhpnhnvhhtfhhvssczztlzzgvvqqghqgqssdscsnsrsmrmmwgwmgmlmdmggbgzbgzgdzdzccghgfgddtntftddpdrdrmrjmmmzttqmttnwngggtgtqtqnqhnqqpnnntrntrnnshhjtjzzfqqblqqlblslflmlttcwtwzzrlrnrcrrrgtrrftfhthzhggwggvgvvfvddcnddfjddzqzrrvtrvrfrrgpgrgngsgddlmddzgzppdzzjzhjhjhqqbpbvvlrvrsvrvnrrsgsttndnbngnppmlppvgvfggvcvrvnnsnfnnfqfwwppnddrrfqqgbqqfmmlnlnngwgcgjgnjgjsgjgqjjnccdttpqttswwcgcmgmccrppmqmbbfwwvdwdfwfjwfjjblldsdrdvvgcvcwwllfpllcslsvssnvsnvvhnvnvwwcgwccslsbbnlbnbrrrtprptpdpdvdttgsgwswppcdchhqbqcbqbzbgbbstshthsttqgtqtpqqzhhwhghwwmbbdlbbtlltsllbvbnvvmqvqtvqvttlwtltmmrttwgtwwfdddwcchtchhbthbbclczzqbzzpvvwzwswggjddntnrnnwmnnbdbmbccqgqvvsnvvqbvbzvvzmvzzrfrlfrfhhdvddnmnnmhmqhhrhlrldljlbljjgqqvdvhhgmgvgddmmznndmmhssznsswvwdvdzdhhscssntnftfmmrggbmbmgmlltctbtbntnqqscqcscrcrhrlhhdchhzccvvbfvvpfffbwbsbjjmgmwgmgppjnpjphhlmhhpwwhwzhhhzbbzzcbchhpnnptpvphhsdsccffqbqllchlhlwlcljlppnccqsstzstswtwwljwjmmpttvqqspsjjclljqqlhqqtnnbrrsbrbjjllrmrjmjzmmclmclmmcvvbddhnnmhmbbwqqqhrqqtqmqbqdbdtdvvcscshccmffhqffdgdcgddljdjbdbjbdbrrtjjtnntpntpnpmnpmpgghffrnfrnnmdnmnhmmjcjffftrrttfwfvwvcwwrmwmpwmmnvntthmmgmbbcdclcppjhpjhjwwlppgsszqqwggmttfrfqflfsfmmmhchshmmjtjjgdjjnnsvsmsnwcgdfqljmnphlfdrhpggfqnhnszgpndhdqcgfhtdcgbsbtmhvnnrmqzqqcjdqndzbnrhwjvbvcldmnwltgpqbmstntnggtbqjzzqrfdsfttdfrcnsrpwrjrjqbgtjfmlwsrzdbdqvbtczgsjqhtgmctjfmdglfrsvqtgwpbqghzgzdfwzhbdhlmhdvhwjrdhhtjptvwpmjnmfcjdmdczmczvdqwvbgtvlwvwnvdlbqfshmlmvzzcmjbtpwpwgsqhfsgljzhbppcztfjdntzcvllqnzrqjwfjrlgvhmbpvbtqjrdzcsmcjzcdsmvcmhrbhgnscnfrfmscqsqpqplbrzhsrlsvvpmfdtdmtlrtvspmlljmfpshfmstjgnrrwmqlbnwbndcfdstrtqtnzpfqlcgrzmsnmhllljdgtmvftjttbwhqzcqwbwdbshgcqrptfjwbbfsjnvzztlbdchqrlbbrcnsswmhwphfwrbnvrncbrthprmltlwwlfpbqhdfqzwwcwjgqzdnvmhwpzpbtpwwvzcpfcsfqpwjljzzfwzmlfvhsccppzlzjlrvlpdtjpcptnvqjwtdbzrqwnfwmmjndflqqggczrfjlpdfjffctprnmhfdqvnzbfvhszzdmngnlmwzfdrbvlvjnmbllgrczssqcrhbmnpmqlrzgmqmhgsvcdlqnmlhlzvqzhnccbctslzlbcpdvqltqncpcrzwdchrqmwfwlcbcvfnnpjntfrznqdjsdtzqjjttddwvnfqmznhflblzvvtbwdzrrlqlmndzzzwnpbhhlvlbswfjtbnhlccscbnfgjtwbfdlwvzszwnwzhlbcdpvgqjcrpzsvvnfwqcqvrmhzhggvmzwggdpbfrdscjwhsdsbbjcnzldhzcvqtjrhsbfjlrlpvtcqhnnsvslfrdjvjhfhdcfzqchpvvhzbpqglqlrdttrdtndzhnzhtqndghtgmpsnhptprqzhbbdcrgmbvrvqmbptqgnmsccwmhrlpddvmhjntllwrzqwnsjchnblcgndjtmpswwgcstdftqcbhzgttrhnpvrhspjznhhvrlpdqbzzrvzjphcswhljdldvsrdhzltwgrcsvqwnhtqqjjrjgrplzmsnjhzrfbtqgdfgnbpvjrfzrrpdphgzrfbswdhzgbzswqtwwdtrvvswmjvwhqddfzjhgdqsfnwbmlcfwtmpldrdpwjwggbpmncvbghzjmpsqpvnmbhjfzzpsjdgmrtnndhzrphjzdbgrrnthtrfnspdngbdmwbnfjlsndqswfsvfqftqlgqjpfsfpmdbsjfrptvbpvflqgvlmmbchhghhrwmvdlrhlsdtvjjchwglcrwfsfnnbhjbtccbjsfwrbzrvgsbfnvzghhrqblqchjvdtrrbrwwwmfnczzmmrqdggsfrqbldbbfbbcthtsvpcnlbjjztwvhctbrjltqdwbzmrrfslbmjpnqwllbvjzgfsfqqtwbgwgclgdflshfhwggwdqlgbmdmdqglrtfwbddtsltmsvswhgjtqwtnrncpdzhnpfqcjnjzmtbjfzpjwgfbfggmsmfdhfbjctnhchpgfspthdbfpmvrmdbbspvwzqqwnmfwdnnblbcjszbccgflngnjjwsqshfbhjwgzrmvsgnrdbgwfhdvpmznpnvznfcqdclztcptjrrpbmpztwwbvlvtmngfhmfbfmrjbjzlrcvgllrlgthltstnwmffntqrwsrndlzqhztwpcwbdjjztgdzmgtthcvtvnjzzhvstfqhgddddgdsrbcqzqspjrncphhtbnslzphrtfqphffjrrlgwbrwqfzzqvzhnffcwvrncttgplshccglvchvlcbnlthhmzvcrfjvjqfsjjzzgqlpslfwngqnbgcwffpcqhlmlhvwssrpjbrcbftpzbbpptzrdqwpzpdjhtwbvwcqbfnwtflfgzgttglpcwdnzsmjffgfftdnpzlpszmzrrhvlzdfpgbzqlvvfslnndcmjvvpwzwcdzpcttfwbsdswmfqbbhbfbjvbvtspbbhmphzjsjcmmzpvvzhtvzlgwlqqvbnrgtszvghjfmchrwwhpmbsvfmgvqdtmvdtjppchbsgqrtgtnzczqmpgjdbmmflfpjbcdmhldwpgdtdvsbzhztjzfhcsbndfjntbldjnqwdffqspfnlplbtcdjtwdjhldtsdfrnmpfhzghnpcqlhhgblmqjvwhndqfbccvzzlbzbdprvcpwjjhrqnjptwssbjhgvpgtfzqwrzjvbdgwtnmptvdjrffcmbzmzcmrfbjv";
            #endregion
            
            int startOfPacket = 0;
            int markerLength = 14;
            bool found = false;
            char[] chars = input.ToCharArray();
            for (int i = 0; i < chars.Length - markerLength; i++)
            {
                for (int j = 0; j < markerLength; j++)
                {
                    string substring = input.Substring(i, markerLength).Remove(j, 1);
                    if (substring.Contains(chars[i+j]))
                    {
                        found = false;
                        break;
                    }

                    found = true;
                }

                if (found)
                {
                    startOfPacket = i + markerLength;
                    break;
                }
            }

            Console.WriteLine(startOfPacket);
        }

        public static void AoC5()
        {
            bool IsSecondPart = true;

            string input = @"move 1 from 3 to 9
move 2 from 2 to 1
move 3 from 5 to 4
move 1 from 1 to 8
move 1 from 3 to 9
move 1 from 5 to 7
move 1 from 5 to 3
move 4 from 4 to 2
move 2 from 3 to 4
move 1 from 3 to 2
move 6 from 1 to 5
move 1 from 4 to 3
move 1 from 3 to 9
move 4 from 2 to 4
move 4 from 8 to 7
move 3 from 2 to 6
move 1 from 2 to 7
move 5 from 5 to 6
move 1 from 5 to 8
move 5 from 8 to 7
move 7 from 4 to 6
move 15 from 6 to 4
move 1 from 8 to 7
move 1 from 1 to 5
move 1 from 2 to 4
move 2 from 4 to 8
move 1 from 5 to 2
move 5 from 6 to 4
move 2 from 2 to 1
move 1 from 9 to 4
move 1 from 6 to 9
move 3 from 9 to 3
move 3 from 4 to 3
move 1 from 6 to 1
move 5 from 3 to 4
move 2 from 8 to 5
move 1 from 3 to 6
move 1 from 6 to 2
move 1 from 2 to 8
move 6 from 4 to 2
move 1 from 2 to 7
move 1 from 5 to 3
move 4 from 9 to 3
move 1 from 9 to 1
move 3 from 1 to 6
move 1 from 9 to 7
move 14 from 7 to 6
move 1 from 8 to 3
move 4 from 2 to 6
move 3 from 3 to 8
move 9 from 4 to 9
move 1 from 1 to 5
move 2 from 5 to 8
move 3 from 8 to 2
move 4 from 2 to 6
move 1 from 3 to 9
move 10 from 6 to 1
move 5 from 9 to 8
move 1 from 9 to 3
move 6 from 1 to 8
move 3 from 7 to 4
move 2 from 4 to 5
move 2 from 9 to 8
move 15 from 8 to 3
move 3 from 7 to 9
move 8 from 4 to 3
move 2 from 5 to 9
move 6 from 6 to 5
move 6 from 5 to 8
move 1 from 7 to 8
move 6 from 9 to 2
move 5 from 2 to 4
move 6 from 3 to 5
move 5 from 5 to 8
move 1 from 5 to 7
move 1 from 9 to 7
move 2 from 6 to 4
move 12 from 8 to 2
move 7 from 2 to 4
move 3 from 7 to 5
move 3 from 5 to 7
move 3 from 7 to 9
move 2 from 9 to 7
move 1 from 9 to 3
move 2 from 7 to 4
move 3 from 1 to 9
move 4 from 6 to 5
move 6 from 2 to 8
move 14 from 4 to 9
move 7 from 9 to 6
move 9 from 9 to 2
move 1 from 5 to 8
move 5 from 6 to 3
move 3 from 1 to 9
move 3 from 8 to 9
move 1 from 8 to 3
move 5 from 2 to 5
move 1 from 4 to 9
move 2 from 6 to 1
move 2 from 3 to 6
move 3 from 8 to 3
move 2 from 6 to 3
move 1 from 4 to 9
move 4 from 3 to 6
move 7 from 6 to 9
move 10 from 9 to 2
move 10 from 3 to 2
move 7 from 2 to 8
move 2 from 1 to 7
move 13 from 3 to 7
move 7 from 5 to 1
move 1 from 9 to 6
move 4 from 8 to 4
move 2 from 3 to 2
move 4 from 4 to 6
move 1 from 3 to 4
move 5 from 6 to 5
move 3 from 5 to 7
move 12 from 2 to 5
move 7 from 5 to 6
move 2 from 8 to 3
move 7 from 6 to 2
move 3 from 9 to 6
move 1 from 6 to 7
move 1 from 4 to 9
move 2 from 7 to 6
move 13 from 7 to 4
move 3 from 7 to 5
move 1 from 9 to 6
move 12 from 4 to 3
move 1 from 8 to 1
move 2 from 6 to 4
move 1 from 7 to 9
move 2 from 9 to 8
move 12 from 3 to 5
move 1 from 8 to 2
move 15 from 5 to 6
move 2 from 4 to 6
move 1 from 9 to 6
move 5 from 5 to 4
move 4 from 4 to 2
move 2 from 1 to 5
move 4 from 1 to 5
move 1 from 8 to 6
move 7 from 5 to 2
move 22 from 2 to 3
move 9 from 6 to 3
move 1 from 1 to 8
move 1 from 8 to 7
move 23 from 3 to 6
move 2 from 2 to 4
move 1 from 7 to 8
move 1 from 8 to 2
move 19 from 6 to 9
move 2 from 2 to 4
move 4 from 4 to 6
move 13 from 6 to 8
move 12 from 9 to 1
move 2 from 5 to 9
move 2 from 4 to 8
move 1 from 2 to 7
move 1 from 7 to 1
move 4 from 6 to 2
move 10 from 1 to 9
move 1 from 6 to 7
move 11 from 8 to 2
move 6 from 3 to 6
move 1 from 7 to 2
move 1 from 1 to 8
move 2 from 6 to 7
move 7 from 6 to 3
move 9 from 3 to 1
move 7 from 9 to 6
move 1 from 8 to 7
move 4 from 2 to 6
move 1 from 8 to 3
move 6 from 6 to 5
move 9 from 9 to 3
move 5 from 6 to 1
move 1 from 7 to 8
move 2 from 8 to 4
move 1 from 4 to 2
move 1 from 4 to 5
move 2 from 5 to 6
move 1 from 6 to 9
move 9 from 1 to 4
move 4 from 4 to 6
move 2 from 4 to 7
move 7 from 2 to 8
move 5 from 6 to 7
move 6 from 3 to 8
move 8 from 1 to 9
move 3 from 5 to 2
move 2 from 3 to 9
move 3 from 9 to 4
move 7 from 2 to 3
move 1 from 7 to 2
move 10 from 3 to 2
move 6 from 9 to 4
move 1 from 3 to 1
move 1 from 1 to 8
move 4 from 8 to 5
move 10 from 8 to 4
move 2 from 8 to 9
move 7 from 4 to 9
move 6 from 2 to 6
move 3 from 6 to 5
move 4 from 4 to 9
move 8 from 7 to 5
move 1 from 9 to 2
move 7 from 2 to 1
move 4 from 9 to 8
move 2 from 6 to 3
move 2 from 3 to 2
move 13 from 5 to 7
move 5 from 4 to 9
move 5 from 1 to 7
move 3 from 5 to 8
move 17 from 7 to 2
move 15 from 2 to 6
move 15 from 9 to 5
move 1 from 9 to 5
move 4 from 8 to 6
move 1 from 4 to 6
move 5 from 4 to 7
move 5 from 2 to 7
move 18 from 6 to 2
move 2 from 7 to 6
move 10 from 2 to 8
move 2 from 2 to 3
move 11 from 8 to 7
move 7 from 7 to 5
move 9 from 7 to 5
move 3 from 7 to 5
move 2 from 1 to 7
move 4 from 2 to 1
move 30 from 5 to 1
move 1 from 3 to 1
move 35 from 1 to 9
move 2 from 2 to 5
move 2 from 8 to 3
move 20 from 9 to 2
move 3 from 7 to 9
move 1 from 3 to 6
move 5 from 5 to 3
move 18 from 2 to 5
move 4 from 5 to 8
move 7 from 9 to 7
move 1 from 6 to 2
move 3 from 8 to 5
move 6 from 3 to 5
move 3 from 7 to 4
move 2 from 2 to 3
move 1 from 4 to 5
move 2 from 4 to 5
move 4 from 7 to 2
move 26 from 5 to 6
move 2 from 2 to 7
move 1 from 2 to 9
move 1 from 7 to 8
move 1 from 5 to 3
move 2 from 8 to 3
move 11 from 9 to 3
move 6 from 3 to 4
move 27 from 6 to 4
move 33 from 4 to 3
move 4 from 6 to 8
move 1 from 2 to 8
move 1 from 7 to 3
move 4 from 8 to 9
move 1 from 8 to 6
move 34 from 3 to 8
move 1 from 8 to 5
move 1 from 2 to 9
move 8 from 3 to 9
move 3 from 5 to 4
move 1 from 6 to 5
move 27 from 8 to 9
move 1 from 3 to 4
move 1 from 5 to 7
move 3 from 8 to 1
move 11 from 9 to 1
move 1 from 7 to 5
move 11 from 9 to 3
move 1 from 5 to 1
move 1 from 8 to 7
move 2 from 9 to 2
move 1 from 2 to 1
move 1 from 2 to 7
move 2 from 8 to 2
move 6 from 3 to 8
move 1 from 4 to 2
move 7 from 1 to 2
move 1 from 7 to 1
move 19 from 9 to 1
move 3 from 2 to 9
move 10 from 1 to 4
move 2 from 9 to 1
move 1 from 7 to 9
move 7 from 1 to 6
move 10 from 4 to 3
move 14 from 1 to 7
move 2 from 9 to 1
move 3 from 4 to 6
move 9 from 7 to 6
move 1 from 3 to 5
move 4 from 8 to 5
move 10 from 6 to 8
move 3 from 5 to 6
move 10 from 3 to 4
move 4 from 3 to 7
move 1 from 5 to 9
move 2 from 7 to 9
move 1 from 1 to 9
move 6 from 2 to 4
move 1 from 5 to 3
move 11 from 4 to 9
move 3 from 4 to 9
move 1 from 2 to 7
move 2 from 3 to 5
move 1 from 3 to 2
move 7 from 7 to 2
move 2 from 5 to 8
move 8 from 2 to 1
move 2 from 6 to 8
move 9 from 6 to 8
move 3 from 8 to 2
move 3 from 2 to 6
move 9 from 9 to 5
move 3 from 5 to 8
move 5 from 9 to 4
move 3 from 6 to 4
move 1 from 6 to 3
move 3 from 1 to 6
move 3 from 6 to 9
move 17 from 8 to 5
move 12 from 5 to 4
move 21 from 4 to 3
move 1 from 4 to 9
move 7 from 5 to 4
move 22 from 3 to 7
move 3 from 1 to 8
move 3 from 9 to 1
move 4 from 4 to 6
move 1 from 6 to 2
move 3 from 4 to 1
move 1 from 6 to 7
move 4 from 9 to 3
move 2 from 5 to 7
move 1 from 9 to 6
move 2 from 6 to 9
move 8 from 7 to 9
move 1 from 6 to 2
move 1 from 9 to 3
move 4 from 3 to 4
move 14 from 7 to 4
move 1 from 3 to 2
move 3 from 7 to 8
move 12 from 8 to 9
move 8 from 4 to 1
move 1 from 7 to 4
move 2 from 5 to 1
move 3 from 2 to 9
move 17 from 9 to 3
move 6 from 9 to 1
move 1 from 9 to 2
move 13 from 3 to 9
move 4 from 3 to 1
move 3 from 9 to 1
move 22 from 1 to 9
move 1 from 8 to 1
move 6 from 9 to 5
move 4 from 1 to 9
move 3 from 1 to 9
move 4 from 4 to 8
move 4 from 4 to 2
move 1 from 4 to 3
move 3 from 8 to 9
move 1 from 3 to 4
move 1 from 1 to 3
move 1 from 8 to 2
move 1 from 5 to 8
move 4 from 2 to 1
move 1 from 8 to 7
move 10 from 9 to 6
move 1 from 7 to 9
move 1 from 2 to 3
move 1 from 6 to 1
move 3 from 5 to 7
move 1 from 8 to 7
move 1 from 6 to 1
move 1 from 2 to 4
move 1 from 5 to 2
move 19 from 9 to 2
move 1 from 4 to 7
move 1 from 3 to 7
move 3 from 7 to 9
move 4 from 1 to 2
move 10 from 9 to 4
move 1 from 5 to 8
move 3 from 6 to 4
move 1 from 3 to 4
move 10 from 2 to 8
move 12 from 2 to 5
move 3 from 5 to 9
move 5 from 6 to 5
move 5 from 1 to 4
move 22 from 4 to 3
move 3 from 8 to 7
move 1 from 7 to 2
move 3 from 2 to 9
move 19 from 3 to 5
move 2 from 7 to 8
move 7 from 5 to 6
move 5 from 9 to 6
move 1 from 9 to 3
move 16 from 5 to 1
move 2 from 3 to 1
move 3 from 7 to 3
move 7 from 8 to 4
move 2 from 8 to 1
move 5 from 5 to 9
move 1 from 5 to 2
move 1 from 2 to 3
move 1 from 8 to 5
move 4 from 5 to 7
move 2 from 3 to 8
move 2 from 1 to 5
move 4 from 7 to 6
move 6 from 4 to 7
move 4 from 9 to 8
move 14 from 6 to 7
move 8 from 1 to 7
move 7 from 1 to 3
move 3 from 5 to 9
move 28 from 7 to 5
move 1 from 1 to 8
move 4 from 8 to 3
move 9 from 3 to 1
move 1 from 9 to 5
move 6 from 3 to 2
move 10 from 1 to 6
move 1 from 1 to 9
move 5 from 9 to 7
move 14 from 5 to 3
move 1 from 4 to 1
move 1 from 7 to 2
move 1 from 7 to 1
move 1 from 1 to 7
move 3 from 8 to 5
move 4 from 6 to 3
move 3 from 7 to 2
move 15 from 3 to 6
move 16 from 5 to 7
move 4 from 2 to 8
move 1 from 3 to 1
move 5 from 7 to 3
move 12 from 6 to 4
move 4 from 8 to 5
move 1 from 4 to 2
move 2 from 5 to 3
move 8 from 6 to 3
move 7 from 4 to 5
move 9 from 7 to 6
move 1 from 7 to 9
move 1 from 1 to 9
move 1 from 1 to 9
move 5 from 2 to 8
move 5 from 8 to 2
move 11 from 5 to 9
move 1 from 4 to 2
move 4 from 9 to 6
move 12 from 3 to 7
move 3 from 4 to 9
move 14 from 6 to 2
move 2 from 2 to 4
move 2 from 3 to 5
move 10 from 7 to 2
move 1 from 4 to 8
move 1 from 2 to 7
move 28 from 2 to 9
move 4 from 7 to 5
move 1 from 2 to 4
move 6 from 5 to 1
move 2 from 4 to 3
move 1 from 8 to 1
move 40 from 9 to 1
move 10 from 1 to 6
move 5 from 3 to 5
move 1 from 9 to 8
move 3 from 6 to 7
move 11 from 1 to 2
move 9 from 2 to 3
move 3 from 5 to 1
move 4 from 7 to 1
move 2 from 2 to 4
move 2 from 5 to 8
move 19 from 1 to 7
move 8 from 3 to 2
move 14 from 1 to 8
move 14 from 7 to 1
move 4 from 6 to 5
move 1 from 1 to 9";

            List<Stack<string>> stacks = new List<Stack<string>>()
            {
                new Stack<string>(new string[] { "Q", "W", "P", "S", "Z", "R", "H", "D" }),
                new Stack<string>(new string[] { "V", "B", "R", "W", "Q", "H", "F" }),
                new Stack<string>(new string[] { "C", "V", "S", "H" }),
                new Stack<string>(new string[] { "H", "F", "G" }),
                new Stack<string>(new string[] { "P", "G", "J", "B", "Z" }),
                new Stack<string>(new string[] { "Q", "T", "J", "H", "W", "F", "L" }),
                new Stack<string>(new string[] { "Z", "T", "W", "D", "L", "V", "J", "N" }),
                new Stack<string>(new string[] { "D", "T", "Z", "C", "J", "G", "H", "F" }),
                new Stack<string>(new string[] { "W", "P", "V", "M", "B", "H" })
            };

            string[] operations = input.Split("\r\n");

            for (int i = 0; i < operations.Length; i++)
            {
                string[] instructions = operations[i].Split(" ");
                int amount = int.Parse(instructions[1]);
                int from = int.Parse(instructions[3]);
                int to = int.Parse(instructions[5]);
                if (!IsSecondPart)
                {
                    for (int j = 0; j < amount; j++)
                    {
                        stacks[to - 1].Push(stacks[from - 1].Pop());
                    }
                }
                else
                {
                    Stack<string> crates = new Stack<string>();
                    for (int j = 0; j < amount; j++)
                    {
                        crates.Push(stacks[from - 1].Pop());
                    }

                    for (int j = 0; j < amount; j++)
                    {
                        stacks[to - 1].Push(crates.Pop());
                    }
                }
            }

            string tops = "";
            for (int i = 0; i < stacks.Count; i++)
            {
                tops += stacks[i].Peek();
            }

            Console.WriteLine(tops);
        }

        public static void AoC4()
        {
            bool IsSecondPart = true;

            string input = @"98-99,3-97
23-72,23-72
53-62,8-87
21-52,36-51
36-38,37-96
92-96,4-92
7-30,8-60
31-44,43-88
67-73,45-73
37-48,49-62
32-50,1-33
39-98,38-47
11-17,18-88
35-99,36-97
9-82,2-3
27-50,4-10
1-92,5-92
6-40,4-40
4-7,2-3
98-99,46-96
24-38,23-39
5-88,5-87
12-97,12-96
19-37,18-37
14-39,14-85
25-55,24-45
30-92,31-92
49-61,50-79
4-69,4-70
29-37,29-42
12-77,11-79
2-2,4-86
55-55,54-54
55-80,81-86
8-10,7-8
52-92,42-54
32-63,32-55
3-83,2-83
97-97,8-97
13-87,86-90
43-95,42-43
39-96,39-84
81-96,36-80
80-84,51-79
37-43,14-43
46-69,45-57
14-85,5-13
69-77,70-78
18-77,14-14
45-92,22-44
53-68,53-77
5-98,5-7
45-68,45-68
7-89,25-88
24-89,24-25
50-68,49-67
57-57,58-79
21-98,97-99
29-60,14-23
74-97,2-98
56-69,69-85
33-48,6-94
99-99,22-97
7-97,6-95
14-20,14-35
10-75,10-50
2-3,4-15
51-77,55-77
81-94,82-95
39-40,39-58
20-70,19-69
40-73,39-39
90-90,21-90
12-75,10-76
4-25,1-24
1-72,3-71
31-84,85-85
61-71,27-61
25-90,24-89
73-86,73-93
37-84,25-35
96-97,82-97
2-3,5-87
58-59,37-59
97-99,31-97
40-50,39-41
5-98,6-99
1-93,93-95
44-87,43-86
26-26,27-74
19-87,1-18
18-49,16-16
36-56,56-82
54-56,55-60
56-67,66-68
70-98,27-39
55-56,2-55
29-29,30-42
44-83,46-83
43-98,73-97
59-63,59-92
47-47,24-47
64-84,64-70
60-72,61-72
8-26,9-67
12-41,41-41
9-50,51-51
81-87,86-92
75-98,97-98
66-80,7-80
7-91,8-82
97-97,2-96
20-62,21-97
19-20,20-90
85-97,85-99
6-87,2-33
23-59,23-48
49-82,48-64
55-69,54-77
43-44,43-92
90-98,10-89
96-96,10-96
5-93,2-93
49-83,48-49
66-93,58-58
11-71,10-10
49-95,73-95
43-81,43-80
15-50,15-50
24-52,51-53
57-87,57-86
16-73,73-82
51-98,52-88
3-39,39-50
23-23,24-80
88-88,44-87
9-97,95-97
7-52,51-53
6-7,6-98
42-96,41-95
91-94,4-92
30-31,31-96
76-86,75-77
7-98,6-99
15-97,14-82
65-76,66-70
14-15,15-62
2-88,2-98
6-89,5-88
7-79,79-79
25-50,25-59
90-95,56-95
10-13,14-49
18-29,30-90
32-64,64-64
10-41,11-28
34-88,35-35
1-54,6-53
23-97,97-97
6-20,3-5
17-82,16-17
35-52,71-92
34-47,25-35
30-84,31-83
11-87,11-60
3-20,3-19
21-25,26-99
8-12,10-10
4-91,93-97
16-96,10-16
5-24,4-6
8-49,8-87
9-94,8-93
1-3,2-66
5-19,6-25
8-25,7-25
2-2,4-92
30-62,61-87
37-61,38-61
62-96,50-96
16-41,15-41
78-79,80-95
4-94,5-94
52-99,9-51
32-59,81-83
81-86,82-86
21-23,21-24
88-88,18-88
75-88,35-76
20-68,18-18
4-46,5-46
54-82,53-92
13-64,65-65
5-7,8-67
1-4,4-88
51-63,18-52
19-94,36-94
56-77,56-57
3-25,55-92
58-68,57-67
35-89,35-99
84-92,83-84
18-18,19-96
85-89,87-89
19-81,18-95
7-98,6-99
9-11,10-69
4-89,4-5
25-93,58-74
35-67,67-99
17-62,17-62
10-18,19-90
66-86,84-85
2-46,46-46
16-41,41-73
22-92,11-21
9-60,6-61
71-71,56-71
57-58,27-58
4-92,2-91
85-85,85-85
44-66,23-26
2-18,3-92
1-96,30-96
61-80,60-78
37-87,36-38
32-77,27-31
1-67,68-79
98-99,7-65
29-49,30-77
56-73,57-72
63-65,64-94
34-86,81-87
7-92,7-8
3-98,3-97
66-81,60-65
85-85,1-85
16-98,17-40
13-95,12-95
18-27,7-28
26-35,34-77
27-52,27-51
23-71,22-72
12-41,37-40
69-87,69-92
29-31,30-41
62-73,61-74
23-77,23-27
52-57,51-52
12-20,11-18
61-61,4-60
1-98,2-45
6-98,6-90
11-14,11-17
28-53,22-52
43-59,67-75
45-47,46-63
75-75,44-75
48-50,51-52
19-82,7-18
8-41,14-49
53-54,53-55
11-97,97-97
56-87,30-30
14-96,15-46
38-41,20-42
17-23,23-62
2-85,4-86
8-69,6-6
14-73,13-72
21-62,8-69
87-98,88-96
17-60,61-61
10-65,65-65
2-11,13-93
10-13,14-99
10-66,79-83
51-87,2-50
7-86,8-73
53-53,54-72
1-95,2-96
52-73,52-74
59-72,72-74
43-73,74-88
8-90,8-9
11-81,80-94
59-84,85-85
90-94,4-89
36-82,36-83
7-87,96-97
30-99,36-99
57-57,30-57
16-98,4-98
45-53,44-81
83-83,69-83
8-89,90-90
14-46,4-47
80-82,15-81
50-57,58-94
18-98,1-18
17-36,35-79
4-5,6-95
14-95,15-98
59-59,60-75
5-82,6-37
10-11,10-74
19-70,19-69
78-95,77-85
59-86,58-58
72-73,72-80
53-81,82-91
79-97,80-95
9-83,10-88
67-76,67-68
19-43,30-32
84-97,7-83
8-10,9-77
73-74,49-74
2-59,6-60
1-6,6-98
20-92,12-20
68-69,68-74
98-99,99-99
14-15,15-80
23-60,23-98
5-6,5-14
38-42,37-55
4-13,5-14
2-5,3-5
4-35,3-88
20-94,94-94
11-89,10-32
11-47,22-47
95-99,26-85
7-58,6-6
4-6,5-99
4-95,4-96
96-97,1-95
1-4,1-84
35-95,34-91
9-15,18-34
46-65,66-87
38-81,38-71
9-10,9-90
66-99,1-99
4-71,60-69
20-43,20-42
5-59,1-4
91-99,22-75
87-96,62-87
22-37,21-36
16-55,85-99
33-99,33-55
57-98,58-79
39-97,96-96
73-99,72-89
14-74,15-15
10-33,10-11
8-13,12-23
1-99,2-99
83-83,12-83
3-19,19-29
33-50,34-78
14-16,16-68
65-84,64-98
43-75,75-98
26-77,8-25
5-14,15-97
15-15,16-16
15-61,14-15
5-19,18-23
7-88,8-99
37-37,33-37
71-84,18-74
5-91,95-96
92-96,9-90
75-92,3-92
3-95,3-96
75-76,68-76
78-91,16-90
28-65,27-72
40-98,34-98
18-42,19-43
32-83,83-96
20-93,20-92
32-34,31-33
72-95,43-72
15-91,14-92
15-82,15-89
6-94,6-96
4-76,76-93
3-91,4-90
47-72,71-72
7-52,8-45
97-98,14-98
3-98,6-99
2-91,3-49
11-75,13-74
35-79,36-70
24-79,23-79
64-99,63-63
21-25,27-94
3-83,2-99
8-64,33-65
44-44,23-44
87-98,64-86
76-76,9-75
8-64,7-40
76-82,75-98
1-98,6-69
67-79,66-79
59-61,13-59
12-93,43-94
7-87,82-88
8-68,8-85
16-53,7-16
30-97,30-97
21-85,22-86
51-93,44-95
4-68,2-86
5-19,9-19
65-97,99-99
8-63,27-62
46-53,45-50
7-19,20-40
37-77,9-36
99-99,54-97
1-99,1-99
28-57,28-58
1-11,3-11
27-33,28-38
9-99,10-97
41-41,41-46
5-83,14-70
16-91,90-99
15-96,96-96
2-77,1-98
18-47,17-94
7-26,7-27
14-41,15-41
5-26,6-79
44-56,45-81
79-93,80-99
17-66,35-65
87-97,39-82
10-71,6-71
68-95,51-62
23-96,26-74
70-82,69-71
41-99,41-71
23-72,22-71
52-82,48-52
81-86,86-86
18-75,74-76
26-37,32-37
5-95,1-97
43-43,42-64
20-91,21-60
35-50,35-66
76-93,13-76
32-70,32-71
12-85,13-82
1-74,5-73
17-69,16-17
51-83,51-82
9-97,7-9
1-98,1-2
42-77,28-99
20-67,20-22
33-45,33-44
24-24,25-90
97-99,6-93
12-98,11-72
4-17,5-96
96-97,1-95
7-7,7-83
71-72,71-91
24-47,1-23
29-35,30-46
36-74,7-36
37-63,61-63
57-86,19-87
20-40,40-74
5-35,36-72
18-84,17-98
9-19,20-67
29-43,29-42
52-82,77-81
57-78,9-84
7-89,9-90
6-98,27-99
1-90,40-90
1-99,3-98
18-72,31-72
99-99,86-96
50-90,9-89
30-70,29-69
87-98,37-62
32-69,11-31
2-20,3-64
1-43,1-47
16-93,17-93
28-50,49-51
48-97,17-47
64-80,65-66
7-98,85-99
7-39,8-92
26-82,26-27
43-93,43-52
26-79,27-94
14-31,13-31
22-72,21-23
31-77,12-77
18-77,78-94
1-99,2-99
13-22,14-53
12-79,11-40
61-84,26-60
6-40,17-41
34-79,35-80
79-82,78-79
8-19,20-93
6-77,7-56
30-95,26-26
29-70,30-92
1-8,7-55
42-59,43-79
25-89,24-26
57-67,56-67
16-39,50-51
46-73,20-71
33-56,57-71
59-60,61-66
7-20,8-20
70-94,16-34
6-8,3-6
4-99,3-94
3-60,3-51
96-96,65-98
3-81,3-80
60-73,89-90
29-77,28-30
5-25,22-63
6-43,1-42
86-90,1-61
3-74,6-75
36-84,37-83
27-64,69-73
80-84,1-83
22-68,68-69
52-53,52-76
85-92,9-84
6-48,7-48
42-74,41-42
4-77,5-90
23-63,11-18
26-27,26-26
24-93,24-92
13-56,13-56
2-3,2-2
35-95,99-99
19-21,20-22
34-98,34-96
4-88,3-5
9-75,8-74
70-98,71-83
62-69,61-61
3-5,5-7
4-62,13-61
17-23,33-72
95-95,9-95
31-52,31-32
62-98,98-99
67-88,19-67
23-30,36-76
91-95,95-95
25-86,24-60
24-24,25-40
44-91,44-45
47-83,20-46
81-92,40-80
10-60,9-83
81-99,38-80
86-86,85-85
17-92,44-92
14-16,13-73
13-38,12-14
5-42,6-46
29-79,28-78
29-68,58-76
33-54,50-54
50-70,70-70
5-95,3-4
20-38,21-37
2-31,3-21
37-54,33-53
61-93,74-94
16-81,6-81
6-42,41-42
45-61,45-60
36-86,37-89
12-53,12-52
8-70,71-74
20-99,19-84
4-82,83-87
74-74,75-98
11-99,11-94
59-79,45-59
13-92,14-93
13-25,12-93
7-76,6-8
16-70,16-17
7-7,60-76
56-94,14-95
98-98,23-70
1-2,5-70
30-34,31-31
20-71,70-72
36-38,16-37
7-62,7-63
2-94,3-95
44-61,43-60
49-49,49-83
14-98,5-13
6-95,6-95
41-67,68-72
40-99,39-98
58-58,58-70
64-98,63-98
24-56,25-62
32-81,31-32
26-60,91-92
31-37,3-38
33-37,19-33
98-98,97-99
74-76,62-72
4-52,1-51
39-81,38-81
55-75,28-76
45-45,46-98
4-61,3-11
57-98,67-95
1-99,1-99
52-75,75-93
19-19,20-50
59-72,62-63
8-14,7-15
70-89,90-98
4-14,14-94
58-59,51-58
2-98,1-97
4-36,13-36
45-99,64-98
26-89,35-69
34-35,34-34
40-51,39-45
5-92,4-5
1-90,5-89
17-39,34-38
37-85,37-85
39-99,39-39
9-98,11-98
13-72,4-8
6-94,7-80
12-55,13-54
5-8,7-96
32-96,95-97
44-62,44-61
2-4,10-42
41-97,91-97
8-35,7-7
64-90,91-91
55-92,55-91
2-5,5-54
53-95,54-98
63-91,63-94
19-67,5-93
13-84,83-84
18-78,78-83
4-4,7-27
1-99,2-98
51-78,51-77
4-96,5-98
9-33,14-35
13-89,12-84
44-57,23-44
2-78,7-78
40-49,39-41
90-96,18-39
35-65,41-62
5-77,24-76
72-77,77-84
53-89,85-89
30-63,30-64
21-93,21-94
7-63,5-63
63-80,63-93
97-98,14-98
19-62,64-74
72-92,71-91
29-31,30-76
47-82,83-83
38-39,39-76
4-87,11-88
7-96,6-80
36-61,33-37
50-96,95-97
11-81,12-92
14-74,74-74
79-92,7-80
24-25,25-90
12-78,12-79
47-99,7-98
51-60,51-85
49-70,50-70
8-17,20-92
1-11,12-65
41-72,72-72
41-56,40-64
10-63,11-11
70-84,36-85
2-4,3-99
84-84,85-88
19-86,21-85
7-55,55-55
6-71,1-70
15-15,15-87
24-82,10-14
65-80,54-64
50-89,49-98
4-4,10-11
56-99,56-99
32-78,2-31
6-78,7-89
8-71,90-95
3-94,38-93
25-77,85-92
83-88,82-89
34-91,33-90
51-93,2-93
2-63,2-80
4-96,24-96
37-62,37-62
24-38,39-55
11-98,11-99
5-58,4-47
71-96,33-98
22-35,33-35
40-63,39-46
18-18,19-69
12-95,12-44
47-69,68-70
72-74,5-72
2-48,31-47
4-40,41-79
13-83,13-32
47-50,6-46
20-52,20-49
49-76,23-37
9-92,9-92
9-69,10-88
16-68,15-67
2-64,9-57
85-85,16-81
60-60,61-89
9-69,69-87
30-86,31-96
21-50,50-96
96-96,31-77
91-98,20-91
18-84,9-85
11-27,18-18
35-44,35-66
2-85,84-90
58-95,99-99
22-22,21-91
30-90,30-91
15-15,17-94
7-97,97-99
4-42,3-43
26-96,7-24
11-84,8-99
94-95,15-94
66-71,70-71
29-54,54-54
89-89,3-89
74-76,75-77
14-32,33-86
35-78,79-79
17-88,87-98
20-52,19-59
1-1,19-94
44-89,43-94
43-43,26-42
7-45,6-32
5-46,5-48
98-98,10-57
27-86,22-28
34-92,33-33
38-74,2-73
59-89,9-59
13-14,15-38
17-59,18-93
8-91,7-8
62-79,62-89
21-45,45-83
77-85,16-72
62-83,65-84
1-99,1-99
14-75,15-75
28-99,27-28
14-83,4-83
1-2,5-60
40-79,79-79
83-89,84-87
3-3,4-46
3-38,1-49
13-76,12-12
4-7,6-14
43-71,6-72
28-61,12-27
27-32,28-32
17-82,17-83
13-45,14-74
38-99,70-98
18-78,16-18
41-55,40-42
36-76,1-71
12-24,25-77
36-36,37-98
2-2,3-75
2-97,59-98
26-95,27-37
44-46,18-45
58-65,58-74
42-92,25-92
7-86,85-86
73-76,69-78
1-2,3-86
24-97,20-99
62-92,13-92
25-86,24-86
31-89,8-89
13-38,13-37
13-83,24-84
96-96,4-96
26-43,25-26
88-90,75-89
54-59,2-60
13-79,3-78
43-58,42-90
49-53,11-55
89-91,11-90
18-78,79-91
35-99,36-98
36-82,96-97
32-68,36-69
12-98,12-96
23-49,41-49
1-83,2-89
30-36,30-37
14-85,13-84
38-40,9-39
8-86,7-87
2-80,36-54
2-68,69-69
23-49,23-57
13-77,78-91
71-99,99-99
2-33,44-80
48-50,4-49
17-88,17-87
62-83,61-94
35-73,34-72
15-93,93-93
8-40,8-77
21-21,22-84
7-52,6-8
6-97,7-99
38-46,38-38
85-86,4-86
40-69,69-94
1-99,41-98
3-31,2-93
44-47,29-65
42-42,41-65
48-74,74-82
62-83,1-61
9-17,10-18
36-43,44-66
8-95,37-95
5-33,13-32
19-95,94-95
64-65,65-69
16-66,67-67
52-61,45-61
50-73,51-74
3-80,5-80
90-99,68-89
3-97,2-99
18-27,18-27
45-46,28-46
15-54,16-54
14-76,13-75
97-99,1-97
36-78,35-78
40-67,65-67
18-76,6-99
94-96,95-95
95-96,22-84
2-20,19-82
34-83,33-82
56-61,56-57
79-87,78-81
8-57,7-56
83-86,83-85
6-91,90-97
76-86,28-87
95-96,9-94
19-32,33-42
23-30,28-32
17-81,17-81
53-71,72-82
70-72,71-86
34-65,35-64
12-87,86-87
63-68,62-67
10-38,9-39
18-70,18-71
5-6,7-83
59-96,59-95
33-73,21-32
16-65,17-65
24-62,16-16
4-86,3-85
5-95,6-94
15-46,16-94
3-87,9-86
17-56,7-55
22-23,22-62
48-89,47-90
25-26,26-86
64-71,63-64
91-98,7-91
10-10,11-16
25-58,25-59
8-64,46-64
24-71,25-72
65-65,14-65
19-59,19-19
42-74,42-43
7-79,8-90
47-70,16-71
43-57,42-56
40-41,41-82
15-59,15-58
15-84,5-16
1-31,18-30
4-59,5-86
78-83,74-82
55-56,55-96
69-88,8-68
23-32,43-83
2-75,5-96
52-97,53-96
5-80,19-68
6-99,5-5
16-86,2-17
15-34,11-33
15-69,15-69
5-57,6-56
4-95,5-96
41-54,24-54
27-27,28-39
4-28,3-5
50-80,58-79
80-90,80-96
5-98,1-5
71-84,71-83
95-96,63-94
21-96,20-97
75-76,62-76
30-59,53-99
53-93,53-66
21-97,15-99
12-80,8-86
5-21,22-40
4-76,4-75
17-19,22-91
1-8,7-54
9-57,5-9
5-84,84-87
56-56,55-85
55-57,56-72
25-32,36-58
58-95,59-96
7-35,49-54
3-95,96-97
40-43,40-70
14-90,13-89";
            string[] pairs = input.Split("\r\n");

            int redundantPairs = 0;

            foreach (string pair in pairs)
            {
                string[] elfRanges = pair.Split(",");
                int elf1Lower = int.Parse(elfRanges[0].Split("-")[0]);
                int elf1Upper = int.Parse(elfRanges[0].Split("-")[1]);
                int elf2Lower = int.Parse(elfRanges[1].Split("-")[0]);
                int elf2Upper = int.Parse(elfRanges[1].Split("-")[1]);

                if (!IsSecondPart)
                {
                    if ((elf1Lower >= elf2Lower && elf1Lower <= elf2Upper &&
                         elf1Upper <= elf2Upper && elf1Upper >= elf2Lower) ||
                        (elf2Lower >= elf1Lower && elf2Lower <= elf1Upper &&
                         elf2Upper <= elf1Upper && elf2Upper >= elf1Lower))
                    {
                        redundantPairs++;
                    }
                }
                else
                {
                    if ((elf1Lower >= elf2Lower && elf1Lower <= elf2Upper) ||
                        (elf2Lower >= elf1Lower && elf2Lower <= elf1Upper))
                    {
                        redundantPairs++;
                    }
                }
            }

            Console.WriteLine(redundantPairs);
        }

        public static void AoC3()
        {
            string input = @"DMwrszrfMzSSCpLpfCCn
RMvhZhQqlvhMvRtbvbcPclPlncddppLTdppd
tVMQhFtjjWmsFJsmsW
trRtvNhfJhSzzSTFVhQQZQhHGphP
CnLMBWLwDMgMcwwdngdHGPVTQGpTHZdGPGpd
LLDqcDgwqCMnLWqtvzrzbbtJqPjJ
wQQwHNQLmbWQbQRHwHNFBbwqPfjqlzRMGRqzpSfvPlzplM
nCtGCZZtsGsrtDMZpfMpSlMlvlZq
cJctJCgVJsCJnDTsCthGhGLwBWBbbQmLbgQLQQdWbbbQ
ZWnNlTNTnhhQQlDNdmmpwrrrqBwjwjZd
GzvlVRSfvMVMvGlSpdCCdjmfpmBCdsqB
bzlFlLzJWLHHttLL
SmzFhVDzrmSrszVDVhSVbhZcCZdfZNcnMfMbZnNN
PTTRGqwqTqWRwLgTLTZGnCbZbNddZCCtMcNs
sgPqPqgJgWWqjjwgwLLVFBFSVmvmBBrmJJDSvp
CBccfSBhcSBddfgtlJmmmwmPRwmh
FpTzzGWHWprgDtJlDZDPFR
HbbTzWnTrnWtCbQBbQqQbSjf
fPHspCjgwZggSvZQ
RrNhzFZFcNzFLNLNwQlSlLnv
TRFrcDVrrRmrhFRZzVrczqhRpjqjsssCpfHjsCdpsPfpjCMC
ZBnBTMVTSbGbTVTGbCPgqsgPtHtgCcPtBB
ldDrmnnNrzhdhfgcsHqcsfCcsCHg
zFdrzNdzQNDDhFdWldDrJTbZTbLZJVVVpMVWVnLS
pLnpQNhBbnWvbsWm
FrFwjlTPTdTqqrDZWbvmZbpSgmJWvbgS
RqDqRrdGFpGRFrFFdTNzCcHcHLHBzQCcNNGN
bvRCtbtCPfSGtCcvCbPNlglqgqlGZMzTgnlZnq
hrmWWFspsHWrzNwTnFlTMTwFFn
HpjJDWBQmmQdRffbPtSzdJ
GpHjFsjMFpCpMWjMGCqWmmqrWQtmthdbDbbD
fzgLTJwJPSgJgzSzPfhmqmQhQHzQtbQDrrmq
RNlBRwHfRJHLLfHTwLSBppNGvjNMFFCVpVFcvcFC
SfQnfSFHfnvMtQQSnHJtMffsdTlZtdZmtllmTlmlRRbBRLDb
hrwhWWwqzPrcCzwwzmPlRbdmlQDTPPBLDl
CpwCzrwGzNCWrJnMvpMvfJVFvQ
rCRPpgSggcpqrhPrCDDTLsMLDSDGLTMGVs
HdvzmRWmlHzwvWHvRHRvHJbDFsdMssQQVGMDTMDLVLLFLT
JBlBnnWBJlCqZRRqRBpr
GtZllZDlfDpGHZtZBGBZpDmzQzzCSVVFHmmmsPCQWWSS
JvFJJrwvNNcJTnbrTRNRSCzqwSsVPCPQqmCQszVm
JLMnTbLnMgBhDFDf
lffDhtgDJzCJNGGTzWTRRnRvBv
qpbpdwqZwqZSwMPSqdQcQmTRnWvnBnRBQBtVnTvWmB
SccbbwSbZbFPswpSZtgFlClLhgChhhNfJlFj
ClmCjCJBjwBVwJGjlGNFJlVMHSrfpDpTfrHMcHTppQVrHp
dRLZWLvWSHmTccWW
ggtqzmRZnmhghZhZghntdqsvBbjlbNFFBPwNNJNNCBlwPGBz
HZmsFZQpvZsWCZQvWrghGrhtgNzdHddHGh
fWSbqWDJVwcSccNzrNhcBtGcgG
VqVfTJnbWjqTSqbwDRfRvQvFpFLRpZsssQsCQZ
FpFZNfplSTJmbZzddGzhDrWh
LqLPPQjLLRMPqvjLLHQrLqrRWdzHnGhdthttGGbbDWhDDdWz
sMLMgvRLgscrLrRQvwmTNNfpNplglplfmp
MPVBmCmWGWRPPqRhLcnjcvjjcpjMvp
tzwrwsJlrldJsrsrTtrzrTtSNnLJSShnjcncvnvqnSFnqN
rswrzsbdwDHHbWZqVfWV
dVmmMTmBPTrCBRMCqFHSWFFHWzCvCz
jNqfGsDqtsjGjQjDlcJFFFznFtzznvtFpFFp
fNNhgsDcfNflqchVRdgVrRPRdVTRRb
HJPLwgLvjttmgHJFjwHgtlsBbNbbNsPpblspTllThT
MzmcRRrdDMVTzbhNNSszhl
mCDDVqdVcdDrqfcCnrFwtGwvngwvtWJtFjWW
dFDpmttBlvNNgWlglNDBFttmTGHTcSSJJHHnMsJsGGSdqcJj
zLbwMLVQbQRwVsJsSHSsHcJqbj
wfVZLPzfZZmpMZZMBl
PZHZMJSTBWHNWSHzVnhhfnhThhpnpC
jFdBBtrFjpfnjfnf
ccGrbblbGRDQMlvmQBvmBl
PCCTsnbPbHDnlDfDNB
rMjQltgSqtvMjScQggjfVVzBzFHzGfVGDLGBqB
vdtrMSttcdwcpSQSdglMrtWRRPJZCpsRZJmWRRWChWPh
pWzbsPCCPPpbptSMCJJwBQQGQt
cDDmcTTRRqzFRddVTSJwMShMtBwhwQMDwv
HldqVmVlZdLTcmRFdrngNNzrffjWpPLggP
JPqvjJmmqvSLmPtpZdcftdmtfdCC
swwhDRwBBHjFFBtBfZ
RRzNQDwznDsDwWJjLNlrSPLSTr
VQmdRLvDlmqZdFrBBJdW
CMstGsnHnHGGMrMZwMpwBSbW
GnsshssNfjtsnggnHCGhjtmfLQQczllvDRVTTQllQWlQ
dhbNbswbwVdNtVdstBtgbNQTBCCSFTmfmMFmfRqQmmQM
HFljLrvZfMQQQPvm
WrpznLZZrnplpWbgdFcFsNzszgst
LjddfTlMccnBfDQBtBQb
ZRSNchHwhNNCHNSWPQFFFHDBBtnQDH
CNpZshSZgpwJmpdLMlplMc
bTmTFmqzgbBntRVsFvVwcv
CZfMrlZLLLMlfPZRLRHGstnjGwtvGcsSVwtcSGvn
ClZpMLCRMZMrHMLmWpqQBpzpgQzmbg
jDmSSGWDDdWdSqqDDqCqpJzqRRqpJnRsMRcMzM
lPgNPvPrrgNrPhNszFggnRzccbMJgz
ZQTHQvQTZPrrQlBBrNvQZZGtTtGdsVCGsCTLLGDmLsjt
rbCfBrbsvQqRFZRNZC
HLSTcwqwZSQFFgRZ
wdDwjpMHqJDTMTdqjlfBvGBhsbfhbsnb
ZhZcHHHlhgchHhlCZZhLCCbGdrsBBGPNBjGbsjNNjnJnPn
wtJqqwDqQQMQFqSqTzwzVTBnGdsjBdnMdPGBBsBdnrjr
RVzJzmSVZmLLWpCc
gdqjQQrlhhQlQrhsnjjhLgmmvmHBBmTmZRsHJzTBHRJv
NwNnGNbGPbmTGpJzppBG
nDnVDfMDrQqQStgM
MLbgbppMMgLmHgQttGQJgJrBShwNShWBBSNNrwNqNN
GnTFlzCVVwPRrVWhSw
GnDDdvdnZDTdnGMsHbbttZgttLbc
mdmPmjClrTzqttfm
cpFnSbcQQsqNNtqWJzHS
QFpcMMBcZtLpQBjVjZhlPjjVlwvw
spVsPjTZZMpZMVLDjmdSQJCLJSmLzdJQdl
HhRnNrqwMhNhnqnHwGNRFBNBrzSCSdQmQCdddbrQSSclSSbQ
nFNqGRvqBfjMvTssfZ
FjjzjnpFqqzFFqgFSZjBhHfHhnHRDDwfdTdLfD
MmCMGCsMWbtJrtCWCbmsmWWhdLGGwRBwdfdLhdTLhHHTBd
bJmtrRvRjgzFFvVq
RWwWmVQGMFGmMGVCVWRRZSBgDdSdJGlSJpcBGGSlpJ
HHhQThnjBDHfSBlS
bPhNjbsssQzFNQqWmz
FTDtrjqwwqGtDbGnfBlcnLcWBZwlWn
mMhRMvJsJvJnMHCvHmhLZLQlhWQBBfPfLPBZ
HRCCsdNdvNmCvggFStbzjbGSSjjn
sLGddsvvcZmLvrLMGcMsVnTTlqlHCsTHHVVgVt
wRbfJPbpNRffRJMBhpDntTCHFNVgqllFlqggHC
DpfbPhRDJPMJppJwzfpbbDGSjrGZvdccQdjGvQZdvrLz
wTwLNLVTqnLMsBwfMsJmCj
JhlGvcdJhSFvFvvvMfgBpCzjzdCfsMMs
DSlPPJSGWrDcFPhtFhWJZHQZLTQVnRWRbHbZHQQT
TmTgTrPDNLNVlDrmlbgNmrSSGbzjZGMvjpZjvvphWMzW
QtBfdfQcdfHtZcnZnGZzchnp
HQHwRBGfBCGBtsrCNPDTmTlNLr
bfNhjhNJDWhlWhlRRR
SsscnHgnSnZnltqqfWRWrzZv
cnfTMfmMnTnmFGsnTVLLLpQJbpbbjpdTdN
BqwZzqRQQRRPSlFRQDDwdfWwhJphnfgfnpMdJfdM
rcTLrcrvDDChWJhfpTgTJh
DHGbGNVCZStGqSqS
dlfdRNNfVdLwrRnwdwRmhLFsbsJJgLqbgCBWBCsW
PHDppMPMHHDPzmBBCmWJqCmbJD
HzzZHmZzQcNdRRdZwddr
wrlshslPsSRfvrQvwbrslCDghtDgCVhDhBVJCFHddt
mZnGpWpWzGTMqnFqDqJNDNFJVJqH
LjpzGcjMGcTzcmmznWSRsfRPfcrbFQcfrwcv
rWBmmmtNmmtBbtlwnhJJVZbw
FsRcjGdLdvFslZbQJZwQps
GHFGvMccFPjgDNbmWWBTTHNz
GhHzmhmwlpbltGBmBmsZsBZsfCWC
rgrcCCPdsWBgNVBD
RnRMdQPMCqndSdQdcQhblpLLwhJbbpzGzwpS
NNQtStFPpJwhRbRzRbqpZZ
jLnmdJrrdDTdbgWbTbRW
JHvnMCmDnMnMljLCDmMLjHNFGGNBPVtQQFtSNFQtPQBv
BFbBRllFZJnPVJbV
GpGHwgzcLhDcwttwthzzhHcPTjZjMgMVZjgZTMmTnMZWJVJm
GccwhqcDtlrPqQrRNQ
gWHWLgHBHQdFhjGGThTQhR
pZsSMpZMJJSzMszzzqclpfjvrvvcRGGTcTVhbVvRbTGTRG
lnMwsqZqsslpjlSMSsffZqqJBgHNNPNDWdLLgdDgdLHPWwCw
qfNvBCBfBqfNMBqCZZfcnmnvtwScpwFSpSsSwt
HzdVzLWPPGGDdnsswnztsRsnmn
QddWVQgJPPHJTJbjBtNTTq
DdRDDPRGGPGccfcbJwsbJWzsnznlLLWzWTLWhVVVVS
CvCrNCqgFqvmqNZFZqqZvpWlVrlVhlhnTLShlDWnzVBD
jvqpvpvpQNCQQCZZmmNgZfdGddRjJDPRMHcHJDHPJf
ttdtBtPPMqWMdgPPBbVGWfTGTTzSVLfVrzCS
ZpDpvRpZDDcmmjmZfLSrwzRnSVSnwTTR
ZvQmjFVHJFDcQjDlZcDVHdqMNtqNBPtPJtbhhbdbts
dGdwwLLpgwgssJpgssNhpJlnbfjnzFfcbfttGjzjlntf
VQvDvHVVQHrQHDCZVBChrHFtzffnfltFFtncnvFtllMl
VBShSqDVRVSTmppPwwsP
fTFDTLNNzlcNrmDcrMDTFPwCSsbCbPPsnCPwLSPvbs
ttQqhJtBRRGnvgHGnlSnbl
hZBJlQBRjVRBRjhtRRMNFVmFmfDNrfWcFVmD
mcTZFBFmqBjmBgPtCtPprmssStCP
LWDQNqDJfQNJddnWfzhfsPRVppVVsSptftpVMS
NDGnJDDDbzddWdNbGNQQLQbqqFBBFcjlZBlHjlZHGBTvZB
PwDzvphPwVwWBqLLwnJWTq
jdCGCgjmllCrmmlmjrbgmRdgJSSJJFLSSqJfLnqLLLbWffLB
mRdjcMHgDpZhDqMZ
cqLjhhrwZwJbBqZhMwbZZdGWdGSllWFvLFGQdnGFQG
gHHVzzppRVggcgpcGWRQRSvdSvvGWvll
HmNNHtVggHsHPtrhJsbjbwCrCqJc
zqPvzLVvzFFQZzWpRLlmHRDHmRCHDH
dNjnJGGrGdqqMprRlpqB
GsgtjhSsSvvSFqvP
pVrfzzjrjWVWTWjrNZvnJSJZqnnqnpSZZS
bdQVQPRPDdcbRGPFddRVMVlZlMlBqSBBZSvSZwnwvJBS
bFbcFbCPPCbbVHCCdVgWfrzjmWfrWrNWgHfT
JgJqLjjjVGgdqGDZGzlGRStStT
PHrHccmrMrTSMVStRtRR
HWPWffNsrppfPWNsVFsmPNCJwwjdJdvdvnJwghBLJLpdLJ
HtHvcnDSDgDcDHtpLrvwjwjfZMjffw
CPWzdJdqVdWZpnLdwnrfdn
GNCNmTQnPVRRglSlHsSG
FJdhjTPbdPJjTPjTjPtSLsSBWWRcCvCvsBWztc
MfGgrHMDDpMnZGDLCRLScCsBlgWvzB
HnmpmNNHGZZpZZrnMPFFbNCNbFdTPVFFFN
TJrrrJQTqJqmTltfRrgfgtgFFg
jLRzBvBjjcnFBNwWlgBZFt
RMjMCGpGzGznzhRmmPPDPsmMmPQmJs
BZqwQCQZGZcVBczqBHtfbbbWfTqNWfMfPNqW
LLpmFjpvpHrvRFSRDRMWbdbtfPWPbjtMgMtW
SDnrpDprDFnQhZCVnhcH
WTsBBQTfQQTTbJBbZbnfTsRFwFrjwjFlrRqvrrlqvWRV
pGcShcGSLNJNHCLttlpllRFgpRFlRpgRrg
GzcMLScSGJGtCbsbQfbZbMBnBn
NGCLGjVjZjQwTGJRQdWM
cFTcvSrFmnnpSmndMswsRMJWRwMHps
rrrhhcTznqvzmcccvvmhgzqDgbgttlDtjjjlfVCfZCjZZV
ccDMHddWNDnnNWMMzdHJJmSQhfQZfvQZflrZQfdVfLLZ
bgBFRTwFtgqCgpRGFpvpVllZlhjrrlVlvj
wtbBGPTPtRTgbCTBqFgGRwFnsWJnmDMsWMJJMzHPhDmJzP
zsbsMtMMdnffBbzNsBtCCWLpLrCrcNLVDWVVcD
TmPhJRvwmjmhFJwjjRPFPTvJGVCcCGBrDpccpDrCrWCVDVFZ
QvSTvBhqwjPmwddHgtqMnllzMl
gftDtqnpqzGZsFcthbtZ
VlNPrBrRNrLBmdRVFCcGCZTFCsTCsbLL
VdldlljlSNHBsSlqfgqMDDvzpHJHWg
tQDLvFLcDrWrcnsHffCGgGHG
ZRPTPJqhMZJZVllRZJPVZPRHnhCnfdssnCznzGhdgfwCHn
qPqlPVlTlSqbZZVJplqlPDmrjWFtmLtFWgQvtmtFvp
zlZzdNRPgGGzsLGCDBBtCDCtSncScP
vWvHWbqjrFMbvrTWcVnQBBBSjLDcQJcL
wfLHwfFqLFbhHvWhMWqwbwwRspssmzgpzGgmmNfmzmRGRz
rPvLrQBvBLsLLdtrgssgZjwFwlnCFMtMFnlllnnb
mNmmzpWHlzjlJMJb
TVSVTWpqRWpSTqNbTVRBPDfLLPrSLrsfQrrvsf
nRjpQWnQnRQzMjRdrtvvPCfmvGtPfMcCtG
TDbrbhNZVbbbbwhDZDhbTTGfcftqcGVvmmcqcJCcCPmJ
NLhrSwgwgnsLsQWljW
JWqVSpGNPdNNzdZJJpMzHzwLgsMwzwQwMBgL
clrlcvrRfccCtFbHrBWLgwLHmMHsHg
DbfDFjcvRcvchWZVWdNpGZNqdh
sdfvFLfmtszQwLfddRpmtDDBjVNWGMNQVQNMJGWJMj
lccrncTZhqqcqhWggvrjMNMGrJMG
SblShnZCqSbPhhbcbTTSZFdFsFpmdRwPwzvmswLtmm
PGwwHpfnFSvVpWqWCQNNjCbbnW
lmddlhcDRBlLRchdmzbNjqqWTcbNPNWTzz
RBMrRdRhlDtPrJtfwFHpsvrHpFSrFw
hhwlglFFSQndLRFbmCbTTz
NczHMMqzpzPcpfBffcmTrdfGbbRbGrdGrLCL
qNzNPqMjcqNBWWccBHsZPDhJnllwnwvJvQnJhQsgvD
mbmvmvbbprZmlFmZbFgLffgQtFNHNhfqQtNQ
SJcdzjSJBzdBdJDzQhhLQfqzNQQHggRL
jwDwcTTDThvTZPPW
FSVBBBvHvCpVVDDGcGwNNhhctwMvMc
fLLZsZVQmjfTfqQRmQhhtgbbJbGJRghtcGct
qTsTQdqjVfqdVdZZqVLpCpzSpdppBlSpCFdHSC
sQQhWsMmQshlhmMQZFDHDJFjgjzHZgcHdH
LnwnpNRrnrbCqqLpwnqfnLcvFHJFzNcHzJcgJJHgdDgN
wCbnpCfPCVqwwnrrbbPRGMMlSllmlTTmsThVMlsd
pzrprfwgbwtwqzrCWbqCwqSMvddHdDSvtHRlDnRRDddD
zQLzQQjPBPFcLcQFTFsmNQzcMNdDdvnldHHvdvnDnRnlvRnJ
cTZGzzscLcPrqrfrZqqbVV
DcSdcTwDLmcwDwvWssGfJfcJQZPGnfcs
FlHFMgtgNggpsztMHMqpjgBBnCfPflfQnZCQBBCnRPZC
gpVjqNVrHFtjqqzSLDTSmTDwwrmhbs
MLMzJTsZzZMgMLgHMmVmdCVhCBlQwDwwhChD
vtPRQpbqCldwdtBC
bQqFbnQbcFfjPRFPQnTrMMgcJgJrssrzgrgS
mtdGJmQRFmdtQvdvtRtdHzHzqZqpHFzZnCzhZjjH
fPwVlllswMVNPfBDDlNVsMsfcBjchHncqzjZbpzjcqCnpHHn
rlsNPWNlhWTPMMNPfwNWTLQRvQLLmgvSJvRJgTRG
TwnqhqqgvQnGBGmBDp
SMjclJSjjVJgCzCzNgpmdBpmBGspRBmpDDVB
JjMCgMMHMMZNStllZSNHhPqFhFWfqPPqTqhLFqtL
lRQPtjPRlDdStDSlPmvllvLsCphFfCHLHggspgFmsFLH
qwpTNprcbNWVHLrfFssBgFCM
NTWTnzTTWGZZZVRSRRQGpdDtSQRp
gpwTPNPBPTdLLLLVGl
jSHdjzZHMcDVtDvFjtCF
HqfZMHzbcqRRRWgdqPmBBBNmwW
PvSBtdFgvSmBPngFBTBjbSjwwpGjsppMjNpMjj
VZLfVQLzQQQhllpcNcwbssvwwwZj
vHWLVVqWTmTgttgq
CNRmNRFNRCWbWNCrlmfGlWqFLsDZQZBZzgwQZsBsDZZCzczB
MSjdVHvHnDDhHvdwBwssZVzwcgLcQg
HnMMTdttHSHSpHvDddpSHTjWlNWFlmRtRmRbqGfqGGNNfR
fBLTDppznrfTndfnfTzTLPvZvvHVbRbggjvzVbzvbV
mwmDGGlqDhMqthGqhJMWmlNVRZPHjgwjjRZbbHRgRHvv
DmhsJsshWGhSGlmlmrdcLLsTBBfcfnBppc
mbCGFFmGmcdTrCTQdh
MJHfJNLllJffPLRTdBqTRQNcqQGB
fPJHfSSSWfSLDMLWGHDMLDFmznmsjmvZwzvjZjbvbZ
pPvpJSfZTTvCzNZczzQZchcj
svbHWsqsvbsMFtVHgVtcRQcDlQRRRQLjlqjczj
tBsgvHVMFggbgFrgWnwSndfBmmBJfPSfpn
jwbwfjSbwjVSjvZPzWSvhvhQlCsBFgLRLLgBLRClLLFQQw
GdNJHpmHTDnTNJqnFCgBLFLFzFtsQRCd
NpMJHpnMrDpJGTHqTTmJHTPjfcvbWfrffVzvZfVWSbjz
wFwpqWwwpqwtqqrbCFtptDmCcfNhNRzRBZRRJRChVNBZBJ
svlvjHsQlvdlvMLdlvPSSLtzzczcNhJthfNtRcNMJNMc
HvvPLSHjgltjsvqwbbnmWmDpgwTT
zhCmPVwwChdCBtsWnNWswBWr
GJJSfSgFpjJjGgpfpgrcNNstvnBHNnHLtFHr
jgDTfjpMgZMGMGJTMMJRhzZPCzbhVlPqdNCbhd
bDbQQmVDRpDNbRQlfQQZnfwTlllfsT
FChzzBWhVzrgMwffJwlnngnTlJ
MCvqvhFzcHCChjtpNNVLppGmbq
bZZzJnccqdzcLhrcQDLrDs
FfCfWVfjWTFClClfwjWCfGGwhZSDhSLsSSRpZprLph
mFmTMmFjMMWFfZtttflWjmWTngNHJHggJJHtzgnJvBtBgHdv";
            string[] rucksacks = input.Split("\r\n");

            int prioritySum = 0;
            for (int i = 0; i < rucksacks.Length; i += 3)
            {
                foreach (char item in rucksacks[i])
                {
                    if (rucksacks[i + 1].Contains(item) && rucksacks[i + 2].Contains(item))
                    {
                        prioritySum += char.IsUpper(item) ? item - 38 : item - 96;
                        break;
                    }
                }
            }

            Console.WriteLine(prioritySum);
        }

        private const string ElfRock = "A";
        private const string ElfPaper = "B";
        private const string ElfScissors = "C";
        private const string PlayerLoss = "X";
        private const string PlayerDraw = "Y";
        private const string PlayerWin = "Z";
        public static void AoC2()
        {
            string input = @"A Z
B X
A Y
B X
C Y
C X
B Z
C Z
A Y
C Z
B Z
B X
B X
C X
C X
B X
B Z
C X
B Y
B Z
B X
C Z
A Z
B X
A Y
B Y
C Y
B X
B Y
B Z
B Y
B Z
A Y
C Y
B X
A Z
B X
C Y
C Y
C Y
A Y
B X
B Y
C Y
B Z
C Y
A Z
B Y
A X
B X
C X
B Y
B Y
B Y
B Y
C X
A Y
A Y
C Z
C Y
B Y
B Y
B X
A Y
C Z
B Y
B Z
B Y
A Y
C X
B Y
B X
C Z
C Z
B X
A Y
C X
B Z
C Z
C Y
C X
B Z
B X
A Z
B X
C Z
C Y
C Y
B Y
B Z
B Y
A Y
A Y
C Y
C Y
C Z
C X
B X
B Z
B X
C Z
A Y
A X
B Y
A Z
B Y
B X
C Z
C Z
B Y
B Z
B Y
B Z
C X
C X
A Y
C Y
C Z
B Z
C Y
B Z
C X
B Y
B X
C X
A Z
B Y
C Y
C X
C Y
C Z
B Z
B X
C X
A Y
B X
B Z
C X
C Z
B Y
B Y
C X
B Z
A Y
B Y
C Y
C X
C Z
C Y
A Z
C Y
C X
C Y
B X
C X
B Y
C X
B X
B X
B Y
B X
A Z
B Y
B Y
C X
C Y
B X
B X
C Y
A Y
A Z
C X
B X
A Z
A Z
A Y
C X
C Z
C X
B X
C X
C X
B Y
B X
B X
B X
B Y
A Y
C X
C Y
B X
C X
A Y
B Z
C Z
B X
C Y
B Y
C Y
B Z
C X
C Y
C Y
B Y
C X
C X
B Z
B Y
B X
C Z
B Y
B X
B Z
B Z
C Y
B Z
A X
C X
B Z
B Z
B Z
B Y
C Z
C X
C X
C Y
B Z
B Y
B X
A Y
B Y
A Y
C X
C Z
C X
B Z
B Z
C X
C Y
A Y
B Y
C X
C Z
C X
C X
C Z
C Z
C X
B Y
C X
A Y
C Y
C Z
B X
B Y
B Z
A Y
B X
B Z
B Z
B Y
B X
C Y
A Y
B Z
C X
B Z
B Z
B Y
B Z
B X
C Y
C X
C X
B Z
B Y
C Z
B Y
B X
C Z
C Z
B X
A Z
B Z
A Z
C Y
C X
B Y
C Y
C X
C Y
C X
A Z
C Y
B Z
B X
C X
C Z
C X
C Z
B Z
B Y
B Z
B Y
C X
B Z
B Z
B Y
B Z
C Z
B Y
B Z
C Z
C Z
C X
B X
C Y
B X
C Y
B X
B X
C Y
A Z
B X
B X
C Z
C X
C X
C X
C Z
C Z
C Y
C X
A Y
B Z
C Z
C Y
C X
B Y
B Y
A Z
B X
B Y
B Y
C Z
C Z
B X
C X
A Z
B X
C Z
B Z
C X
A Z
B X
C X
C X
A Y
B Z
B Z
B X
C Y
C Z
C X
A Z
B Y
C Y
C Y
C Y
C X
B Y
B X
B X
C X
B Z
C X
B Z
B Z
B X
C X
A Y
B Y
C Z
C X
B Y
B Y
C Z
B X
C X
C Z
B Z
A Y
B X
B Z
B Y
C X
C Z
A Y
A Y
B X
B X
B Z
B Z
C Y
C X
B Y
B X
B X
B Y
B Y
C X
B X
B X
A Y
B Y
B Z
B Z
C Y
B Z
C Z
C X
C X
C Y
C X
C Z
C Z
B X
C X
B X
C Y
C Y
B Z
B Y
C X
B Z
C X
B Z
A Y
C X
B X
B Y
C X
C Y
B X
B Z
B X
C Y
B Z
B Y
B Z
C X
C X
C X
C Y
B X
B X
B X
C X
B X
B X
B Y
B Z
B Y
C X
B Y
B X
B X
A Y
C Y
B Z
A X
C Z
C Z
B Z
A Y
C Y
B Y
B Y
C Z
C Y
C X
A Y
C Y
B Y
C X
A Z
C Z
A Y
C Z
C Z
A Z
B Y
C Z
C Z
B Z
A Y
C X
C Y
B X
B Z
B X
C X
B X
C Z
B X
B X
B Y
C X
B Z
C X
A Z
C X
B Z
C X
C Z
B X
C X
B Y
B X
B Y
B Y
C X
B Y
C Z
C X
B Y
A Y
C Y
B Z
A Z
A Z
C X
C Y
C Y
B Y
B Y
C Z
C X
A X
B X
C Y
B Z
B X
B Y
A Z
A Z
A Z
C Z
C X
B Y
B Z
C X
B X
B X
B Z
A X
C X
A Y
C X
B X
C Y
C X
B Y
B Y
B Y
C X
C Y
C Y
B Z
B X
C Z
A Y
B Y
C Y
C X
C X
C Y
A Z
C Z
C Y
C Y
C Y
C Y
B Z
B Z
C X
B Y
C Y
B X
C X
C X
C Y
C Y
C Y
C X
B X
B Y
A Y
A Y
B X
B X
C Y
B Z
C X
A Y
A Y
C Z
B Z
C Z
C Z
A Z
B Z
A Y
B Z
B X
C X
A Y
B X
B Z
B X
C X
C Z
B Z
A X
B Z
B Y
B Z
B X
C Z
B X
B Y
B Y
B X
B Z
C X
A Y
B Z
B Y
C Y
A Y
C Z
B Z
C X
B Y
C Y
A Y
C Y
A Y
C X
B X
B Y
A Y
B X
B X
A Y
B X
B Y
B X
B X
C X
B Z
B Z
B Y
A X
C X
B X
C X
B Y
C X
C Y
C Y
C X
A Y
A Y
B Y
C X
B Y
C Y
B Y
C Z
C X
C X
C X
B Y
C Y
C Z
B Y
C X
B X
B Y
A Y
C X
B Y
B Z
A X
B Z
B Y
C Y
C X
B X
C X
C Y
B X
C Y
B Y
C X
B X
A Y
C Y
C X
A Y
B Y
C Y
C X
B Y
B Z
B X
B X
C Y
C Y
C X
B X
C Y
B Z
C Z
B Z
B Z
B Y
A Z
A Z
C Z
C Z
A X
A Y
B Z
C Y
A Y
B Y
C Z
B Z
C X
C Z
B Z
B Z
B Y
A Y
B Y
C X
C X
A Z
B X
C X
C Z
C Y
B X
B X
C Z
C X
C Y
C X
B Y
B Y
C X
C Y
C Z
B Z
C Z
B X
B Z
C Y
A X
A X
B Y
B X
B Z
C X
C X
A Y
C X
C X
C Z
C Y
C X
B X
C X
B X
B X
A Y
A Y
C X
B X
B Y
C X
C X
C Z
C Y
A X
C X
B Z
B X
C Y
B Y
A Z
C Y
C Z
B X
B Y
C Z
C Y
C Z
C Y
C X
C Z
B Z
A Z
B X
C X
B Z
B Z
A Y
C X
B X
C X
B X
C X
B Z
A Y
C X
B X
C Y
C Y
C X
C Y
B Z
C Z
C X
B Z
C Z
C Z
C Z
B Z
C Z
B Y
B Y
C Z
A Z
A X
B Z
C X
B X
C Y
A Y
C X
C X
A Y
C X
C Y
B Y
C Z
B X
A Y
C X
C X
B X
B X
A Z
B Y
B Z
B X
B X
B Z
B X
B X
B Z
A Z
C Z
B X
B X
C Y
B Z
B Z
B X
B Y
B Z
C Y
B Z
C Z
C X
C Y
A Y
C Y
C X
B Y
C Y
C Z
B Y
C X
B Z
B Z
A Y
B Y
B Y
B X
C Y
C X
B X
C X
A Y
C X
C Y
B X
C X
C Y
C Y
B Z
C Z
B Y
B Z
A X
C Y
A Y
C X
B X
B X
B Y
C Y
C Y
C X
A Y
A Z
B X
A X
C Z
C X
B Z
C Y
B X
A Y
C Y
C Y
B X
A Z
A Y
B Z
B Y
B Z
B Y
C X
A X
A Y
B X
B Z
B X
C X
B Y
B X
B Y
B X
C Z
C X
A Y
C Y
B X
B Y
A Z
B Z
C X
C X
C X
A Y
C X
C Y
B Y
B Z
B Y
B X
A Y
C Y
C Y
C Y
C X
A Y
B Z
C Z
C Y
B X
C X
C X
B X
B Z
B Z
B Y
A Z
B X
A Y
B Y
C X
B Y
A Y
B X
C Y
C X
A Y
C Z
C X
B Z
C Y
B X
C X
A X
C Y
B X
B Y
B Y
C X
B Y
C Y
C X
B Y
A Y
C Z
C Y
B Z
C Z
B Y
C X
B Z
A Y
C Z
B X
B Z
C Y
B Z
C X
C X
A Z
B Z
A Y
B X
C X
C X
B Y
A Z
C Z
C X
B Z
C X
B Z
C Y
C X
C Z
C Z
C Y
C Y
C X
C X
C Y
B X
C X
B Z
C Z
C Y
C X
C Y
B Y
B Y
B Z
B X
C Y
C Y
C X
C Z
C Y
C Y
C X
A Y
B X
B Z
C Z
C Y
B X
C X
A Y
C Z
B Y
C Y
C X
C Y
C Y
B X
C Y
C Y
B Y
C X
A Z
B X
B X
B X
B X
B Z
C Y
B X
A Z
B Z
A Y
C X
B X
B Z
C Z
C X
B Z
B X
A Z
A Y
B Y
A Z
B X
C Y
B Y
C Y
C X
B Y
B Y
C Y
A Z
B X
B Z
B Y
B Y
B X
B Y
B Z
C Z
B Y
C X
A Y
C X
B Y
B X
A Y
C Y
C Y
B X
B Y
B Z
C Y
C Y
C Z
C Z
A Y
C X
B Z
C X
B Y
C Y
B Z
C X
C X
A Y
C Y
A Y
C X
C X
C Z
A Y
A X
B X
C Y
B Z
C X
B Y
C X
C Y
C X
B X
B Y
B Z
C Y
B Y
A Z
C Y
B X
C X
A Z
C Y
B X
B X
C Y
C Y
B X
C Y
C Z
C X
B X
C Y
B Z
B Z
A Y
C X
C X
C Y
B X
A X
A Y
A Y
C X
B Y
C X
C Z
B Y
C Y
B X
C Y
B Z
B Y
A Z
B X
B Z
B Y
B X
C X
B Y
C X
C Y
B Y
A Y
C X
C Z
B Y
C Y
C X
C X
C X
B X
C X
C Y
B Y
C X
C Y
C X
A Y
B Z
B X
C X
A Y
B Z
A Y
B Z
B Z
B Z
A Y
B X
C Y
C X
B Y
A Y
C X
C X
A Y
C X
C Z
B X
C Y
C X
B Z
B Y
A Y
C X
C X
B Y
B Z
B X
B Y
C X
B X
C Y
B X
A X
B Z
B Y
B Y
C X
B X
C X
C X
C X
C X
B X
B Z
B X
B Z
B X
C X
B X
C Z
B Y
B Z
B Y
C X
B X
B Z
A Y
B Z
C Y
B X
B Y
C Z
C X
B X
A Y
A Y
B X
A Y
C Y
C X
A X
C Y
C Y
C X
C X
C Z
C Y
B X
A Y
C X
B Y
B Z
B Z
C Y
B Y
B Y
B Y
C Y
B Y
B Z
B Z
B Z
A X
B X
C Y
C Y
C Y
C Z
B Z
B X
C Z
C Y
A Y
A Y
C Y
B Z
C Y
C Z
A Z
C Y
A Y
C Z
C X
B Z
B Y
B Y
A X
C X
B Z
B X
B Z
C Z
B X
A Y
B Z
C X
C Y
B Y
C X
B Z
B Z
B Z
C X
B Z
B Y
B Y
B Y
C Y
A Y
B X
A Y
C Z
C X
C X
C X
C X
C Y
B Y
B X
C X
C X
B Z
A Z
C X
C Z
B X
B Z
C Y
B X
B X
B Y
C Y
B Z
A Z
B X
C Y
B Z
B X
C Y
B Z
B X
C Z
C X
C Z
B Z
A Y
B Y
A Z
C Z
B Z
B Z
B Z
C Z
C X
A Y
C Z
B Z
B X
B X
B Y
A Y
B Y
C X
B Y
C Z
C Y
B Z
C X
A Z
B Z
C Y
C Z
B X
C Z
A Y
A Y
A Y
C Z
C Z
B Y
C X
C Z
C X
C Y
B Z
C Z
B Y
C Y
A Y
B X
B X
B X
B X
C Y
C Y
C X
B Z
B X
A Y
B X
B X
C Y
C Y
C Y
C Y
B Z
B Y
C X
B Y
B X
C X
C X
B X
C X
C X
B X
B Y
B X
B X
B Y
B X
C Y
B Y
C Y
C Z
C X
B Z
B Z
B Y
C Z
C Z
C Y
B X
B Y
B Z
B Z
A Z
C X
C Y
B X
B X
C X
B Z
C X
B Y
C X
C Y
B Y
B Y
A Z
B Y
B X
C Y
B Z
A Z
B Y
C Y
C X
B X
B X
B Z
C Z
C Z
C X
B Z
B X
A Y
C X
A Y
A Y
B Y
C Y
B X
C Z
B Z
B X
C X
A X
C Z
B Z
B X
C Y
C X
B X
C Z
C Y
B Z
C Y
B Y
C X
B Z
A Y
C X
C Y
A Y
B Y
B Y
C X
B X
B Y
B Y
B Y
A Y
A Y
C Z
C Y
B X
A Y
C X
C X
C Y
C X
A Y
B Y
C Y
B X
C Y
C X
C X
C X
A Y
A Y
B Y
B X
B Y
B X
C X
C Y
B Z
B Y
C Y
C Z
A Z
B X
B Z
C Z
A Y
C Y
B X
C X
B X
B Z
C Y
B X
B Y
B X
B Z
C Y
C Z
A Y
C Y
A Z
B Y
A Y
A Y
C X
A X
A X
C Y
C Z
C Y
B X
C X
B Z
B Y
C X
C X
A Y
C X
C Y
C X
C X
C X
C X
C Z
B X
A Y
C Y
B Z
B Z
C Z
B Y
B X
B Y
C X
C Y
B Y
B X
B Y
C X
B Z
B X
C Z
C Z
B Z
C Y
A X
C Z
C X
C X
A Y
B X
C X
B Z
C X
B Y
C Z
B X
B Y
C Y
B Z
B Z
C X
C X
B Z
C Z
B Y
B Y
B Z
B X
C Y
C Y
B X
B X
B X
B Y
B Z
B Y
C X
C Y
C Z
B X
B Y
C X
B X
A Z
A Z
C Z
C Z
C X
C Y
C X
B Y
C X
C X
B Z
B Z
B Y
C Y
B Y
B Y
B X
B X
C Y
A Z
C Y
B X
B Z
B Y
A Y
C Z
B Z
C Y
C Z
C Y
C Z
B Z
B Z
C X
C X
B X
B Y
B X
A Z
B X
B Z
B X
B Y
C Y
B Y
C Z
C X
A Y
A Y
C Y
B Y
C Y
B X
B Y
C Z
A Z
B X
B Y
B Y
B Y
B X
C X
C Y
C X
B X
B X
B X
B Y
B X
B Z
B Y
C Y
A Z
C Z
B Y
C Y
B Z
B Y
B Y
C X
B X
C Z
C X
B X
A Y
B Z
C Y
C Y
B Y
B Y
A Y
A Z
B X
B Z
B Z
B Z
B Z
A Y
B Z
B X
C X
C Y
B Y
C Y
B X
C X
A Y
C Z
B X
B X
B Y
A X
B X
C Y
B Z
A X
C Y
C Z
C Z
B X
C X
A X
C X
A Z
B X
B Y
C Z
B Z
B X
C X
B X
C Z
C X
B Z
A Z
A Y
C X
C Y
B X
C X
A Y
C X
B X
B Z
C Y
B X
C Y
C X
B X
C X
C Z
A Z
C Y
C Y
C X
C Z
A Y
C X
C X
C X
C X
B Y
B Z
C X
C Y
C X
B X
A Y
C Y
A Y
A Z
B X
C Y
C X
C Y
C X
B X
B Y
B X
C X
B Z
B Z
B Y
B X
B X
B Y
B Y
A Y
C Y
B Z
B X
C Y
C Y
C X
A X
B Z
C Y
B X
C Y
B Y
C X
C Y
C Z
A Y
C X
A Z
C X
B Y
C X
B X
B Z
B Z
B Y
B Z
B Z
B X
C X
B X
B Y
B X
B Z
C Y
B X
C X
C Y
C X
B Y
B X
C X
B X
C X
B Y
C Z
C X
B Z
A Y
B X
A Y
B Y
B X
C Y
B X
B Z
C Z
B Y
C X
A Y
B Y
C X
C X
B Y
C Y
B Z
C X
B Z
B X
C Y
C X
C Z
B X
C Z
B X
B X
C Y
B Y
C Y
B Y
C X
A Y
B X
C X
C Z
C X
A Y
B Z
A Y
B Z
B X
B Z
B Y
A Y
C X
B Y
C Z
A Y
B X
C X
C Z
C X
C X
B X
C X
C Z
B Z
C Z
B X
C Z
B Z
B Y
B X
B X
B X
C Z
C Y
A Y
B Z
B X
B X
C Z
A Y
B X
C Y
B Z
C X
B Y
C Y
B X
B X
B X
B Y
B Y
C X
C Z
B Z
C X
B Y
B Z
B Z
B Y
B Y
C X
B Y
B Y
B Z
A Y
C Y
C X
B X
C Y
C X
C X
B X
B Z
C X
A Y
B Y
C Z
C Y
B X
B X
B Z
C Z
C X
A Y
C Z
C X
C X
B Z
B X
C Y
B Y
B Y
C Z
B Z
A Z
C X
A Y
C Y
B X
C X
B X
A Y
C X
C Z
C Y
A Z
C X
B Z
B Y
A Y
C X
B X
C Z
C Y
C Y
B Z
C X
C Y
B Z
B Y
C X
C Z
B Z
A Z
C Z
B X
C X
C X
C Y
C X
B Z
C X
C Y
C X
B Z
B Z
A Z
B Z
B X
B X
C Y
C Z
B Z
C Y
C Z
B X
A Y
B X
C X
B Y
C X
B Y
B X
C X
B Z
C Y
C X
B X
B X
B X
B Y
B Y
B Y
A X
B X
C Y
C Z
B Z
C X
A Y
C X
C Y
B Y
C Y
C X
B Z
B Y
B Y
B Z
C Y
C Y
A X
C Z
B X
B Z
B Y
C X
C Y
B Y
C Z
B Z
C X
B Z
C X
B Y
B Z
C X
C X
B Y
B Y
B Y
C X
B Y
B Z
B Y
A Z
B Z
A X
C Y
A Y
C Y
B Z
B X
A Y
C X
B X
A Y
B Y
C X
B Y
C X
B X
B Z
A Y
B Z
B X
C Z
C X
B Z
C X
A Y
C Y
C Y
A Y
B Y
C X
C Y
C X
B X
C Y
B Z
B X
B Y
B X
C X
B X
C Y
C Y
B Y
B Z
C Z
B X
C Y
C X
A X
A Y
B Z
B Y
A Y
C X
C X
C Y
B X
C Z
C Z
B Y
B X
C X
A Y
B X
B X
C Z
C X
C Z
B X
B X
B Y
B Y
C Y
C X
A Z
C Z
B Y
C X
B Z
C X
B X
C X
B Z
C Z
B Y
B X
B Y
C Y
B Y
C Z
A Z
B X
C Z
B Y
C Z
C X
A X
B Z
B Z
C Y
C X
B Y
C Y
C Z
B X
B Z
C X
C Z
B Z
C Z
B X
C X
B Y
B Z
C Y
B Y
B X
B Y
B Z
B Z
A Z
B Y
C Y
A X
B X
C Y
A Y
C Y
B X
C X
B Z
C Y
C X
C Z
B Y
B X
C Z
A Y
C Y
C X
B X
B Z
B Z
B X
C Y
C Z
C Z
B Z
B X
C X
A Y
B X
B Z
C Y
C X
B X
C X
C X
B Y
A Y
A X
C Z
C Y
C Z
C Z
C Z
C X
A Z
C Y
B X
A X
B X
B X
A Y
B X
C X
B X
B X
B X
C Y
C X
A Y
B X
C X
C Y
A Y
C X
C Y
C Z
C X
C Z
C Z
B Y
B Y
C Y
A Y
C Y
B X
B Z
B Z
C Z
C X
B X
B Z
C X
B Z
B Z
C X
B Z
B Z
B X
B Y
C Z
B Y
B Z
A Y
C X
C X
B Z
C Y
C X
A X
B Z
C Y
C Z
B Z
B Z
C Y
A Y
C Z
C X
C X
C X
B Z
C X
B Y
C X
C X
B Z
C X
A Y
C Z
C X
A Z
B Y
A Y
B X
B X
C Y
B Y
B X
A Z
B Z
C Y
C X
B Y
B Y
B Y
B Z
C Y
C Y
A Y
C Y
C Z
B X
C X
B Y
C Y
A Z
C Y
C X
B Z
C Z
B Z
C X
C X
C X
B X
C Y
C Z
B X
C X
A Y
C Y
B Y
B Z
C Y
C X
C X
B X
C X
C Z
C Y
A Y
C X
B Y
B Z
C X
C Z
B Z
C Z
B Z
B X
B X
C X
C Z
B Y
B X
C Z
A Y
B X
B Y
C X
B X";
            string[] rounds = input.Split("\r\n");

            int score = 0;
            foreach (string round in rounds)
            {
                string[] choices = round.Split(" ");
                switch (choices[0])
                {
                    case ElfRock:
                        switch (choices[1])
                        {
                            case PlayerLoss:
                                score += 3;
                                break;
                            case PlayerDraw:
                                score += 4;
                                break;
                            case PlayerWin:
                                score += 8;
                                break;
                        }
                        break;
                    case ElfPaper:
                        switch (choices[1])
                        {
                            case PlayerLoss:
                                score += 1;
                                break;
                            case PlayerDraw:
                                score += 5;
                                break;
                            case PlayerWin:
                                score += 9;
                                break;
                        }
                        break;
                    case ElfScissors:
                        switch (choices[1])
                        {
                            case PlayerLoss:
                                score += 2;
                                break;
                            case PlayerDraw:
                                score += 6;
                                break;
                            case PlayerWin:
                                score += 7;
                                break;
                        }
                        break;
                }
            }

            Console.WriteLine(score);
        }

        public static void AoC1()
        {
            string input = @"18814

1927
12782
8734
10904
9548
1493

4576
4235
2617
1012
2088
1325
1249
5173
4893
3295
2376
2714
6210

6684
5766
3442
4901
4875
4815
5898
2410
5789
4133
3590
1342

8867
7109
2904
5810
3254
4257
2508
3580
5494

11885
14638
11891
4244

11603
17113

8341
2993
7759
7219
2962
8020
6176
6100
6168
5467

8884
11521
3912
2993
13471

3093
4064
9130
7665
10440
6175
7390
10297

29896
7553

3709
5876
3564
3824
7695
6789
4295
1603
2170
1004
7871

5020
1414
2741
6719
2845
6136
6399
1252
3594
5522
7969

5693
2115
11763
9283
12287

7006
5946
10795
1196
7918
5157
7856

4240
2887
11614
5791
11635
3458
11730

4843
8330
7046

6100
4280
5609
6975
3704
3033
4953
8469
4844
6110

12946
25227
10688

2403
1851
2695
3953
5878
2712
2516
5473
3877
1955
5663
1627
2777
3082

56364

4636
6558
2535
3165
2685
4797
6021
5666
4233
1469
7070

7209
2433
7902
3515
5477
9505
5126
9294
4364

8355

2434
1139
2011
3784
1194
2270
6072
5157
3428
3915
2201
1769
3530
4034
3381

1032
6856
6760
5918
5255

37294

5331
8102
3359
3692
6645
10076
8602
2726

1196
3789
9127
15026
10039

44620

33181

7325
5261

6633
1629
13650
13046
9180
13952

8267
4591
7888
5919
3255
3938
5320
6318
1016
5467

4945
4766
4089
6270
5951
3624
1294
2845
6236
2284
6016
6171
2888
3417

7105
3162
5163
6685
5034
5590
3857
1349
3110
3216
5713
4128

3345
5178
2139
6009
3656
3985
2925
1878
5277
2548
5014
4170
2068
5406
3782

4545
3019
4971
5443
4041
2992
2572
1746
6324
2505
4059
4559
3282
6281

2479
1227
1920
1652
7127
5330
5773
7980
5979
1327
6926

5533
4924
4501
1595
5068
1872
1756
6565
4526
2686
1905
4323
4340

6740
9667
7552
1838
4250
8439
2018
9334
4571

5685
2107
3006
1731
2252
2543
4018
6351
1533
5665
2671
2983

7982
5914
7895
1973
6270
1546
1333
6630
7107
5563
1223

3377
1575
6806
6269
5158
5195
2001
1896
8137

4449
2044
1954
4646
4853
2901
4696
3729
2467
5396
1370
5768
3729
1122
2760

5594
3736
4226
5677
1451
5936
3771
1747
4692
1991
3244
5235
2494
1136
2600

60004

10268
7786
8060
10508
5528
6774

1428
16323
9092
17680

1278
3760
4600
5281
3371
4529
2906
5004
4326
4382
3507
1738
3022
1261
2087

2088
5008
6379
4057
3677
5741
1096
3156
4884
5431
3653
6249
1959
4851

3198
1054
5059
1967
5084
4735
1672
1975
3757
5140
4123
1226
5561
3002
1048

4155
6076
4411
4147
1509
1410
1316
2436
5710
3469
5833
3284
2004
5333
2931

3722
6554
4079
3647
6665
2834
6111
1699
2264
3301
4618
6804

18306
2766
15246
16034

10794
8795
6042
14744
8731

9246
15455
7276
1023

4976
5679
3094
6609
3132
6317
7249
3085
2201
4788
3853
7298

6328
8513
10986
8497
3620

8570
6016
3967
7081
2226
3628
1183
7502
2675

3713
4940
3895
5463
1568
1646
1933
4149
4542
5107
2476
6416
5590
4177

1853
3161
5524
4869
4002
4835
5345
3406
3809
6334
3815
4439
4804
4653

2340
1068
6949
4527
2062
1973
7159
6917
7989
5951
3967

7479
1230
6619
5481
4068
6854
1792
6293
2888
7018
4381

43123

12920
10198
13757
10070
3194
10576

26957
29555

5102
11583
4272

5229
1697
7613
1254
3850
3959
3011
8327
1583
5689

3069
5459
1921
4279
2614
3025
1134
2718
3784
3160
2885
5309
3048
3150

15015
5487
11549
16223

1700
1079
5726
2919
4403
4004
4490
4474
5385
4940
2019
2426
1774
5222
4095

2109
1692
3529
4425
5017
1955
2956
5193
1359
3071
5086
3272
1148
1244
5108

3183
5818
5424
3009
9660
10737
7805
4181

4393
2248
6731
1691
1330
2227
3580

3097
6770
4477
2274
10473
6196
6291
10213

4466
1945
4168
3012
5737
2918
1568
6018
3634
2373
2398
1899
5096
6008
2990

6237
4195
4209
6274
5259
6651
6781
4354
7187
2438
1651
1455

5091
5021
1578
1839
2447
1410
1551
1273
2870
2060
6062
4994
4425
1142
2121

25078
34262

3027
1504
2559
3905
4918
1442
5269
1792
1787
7325
2833
6804

10472
3468
6981
4162
5889
10528
3516
4516

5317
1944
2244
1565
2805
2058
3249
5589
5225
4472
4292
4096
1682
3780
4732

2155
1915
1390
6056
4997
5247
3565
5359
4920
3193
6103
5942

5728
1735
2890
2208
4913
3879
6078
3237
2997
3109
1150
4648

4368
6370
5658
2440
3404
1849
5650
3261
4920
4114
3673
6330
4183
5309

3227
2526
7386
6005
5441
8946
2415
8447
9143

2211
5669
1077
3134
1072
3419
5779
3499
5291
2636
5031
4309
4030
6032
3512

40358

31692
14965

12952
19656
13010
15201

3398
5373
2074
4864
2925
3543
4632
2032
1007
5758
2815
5935
3093
1169
2964

8110
12093
13122
3915
7332
12319

4963
5227
1525
8650
6907
2828
8473
5287
8196
2071

12969
22624

6327
5381
1572
2113
10240
5360
10614
2960

3800
11368
9929
12344
5461
11666

19639
14660
7046

4562
1583
2616
5800
6350
3762
6491
1047
3559
1388
4772
6413
3066

10721
10685
3925
1461
4136
3510
3989
9199

2538
4798
2645
3236
1113
1155
3634
2228
1475
2261
4527
1498
2891
6087
2632

16730
3334
9006
3657

5665
5504
3037
10040
6716
3769
3756

3537
2809
6097
8067
3411
4135
7782
3367
1799
3663

10185
6481
11360
6493
10001
7424
9674

5844
12305
7993
1325
10357
9896

9400
6803
3442
5199
9582
2029
2664
1211
2642

1069
8063
2822
3453
2786
5941
6783
1145
6080
2862
7190

5080
6563
5357
4338
1616
10436
3433

5512
2337
3013
1399
1058
1381
3681
2549
2204
4949
2928
1027
2538
5636
2195

1847
3848
1883
6559
2248
3401
2301
5408
2119
4829
6262
3358
6641

16613

4989
4027
2571
1680
6420
5858
2363
1007
1410
5902
3149
4577
2635

3689
1667
2261
5602
6024
4590
5938
4165
3867
5605
2519
2179
4325
5723
2871

4223
5264
1189
5439
2576
6225
1931
1656
7521
1963

8246
6922
4192

3380
3689
4228
4975
5185
2469
2912
5014
5115
1276
5895
5189
5345
4321
3142

1190
10126
15028
7406

7153
9689
11330

2185
1658
4927
4138
5015
3019
4896
3345
2600
2515
4061
4969
4687
5080
1922

1780
5589
5777
2203
2353
4076
4638
4756
4865
2753
5506
3414
3719

10077
1961
6853
7785
8162
3223
9308
9503

1696
5954
2794
5953
3074
2389
7979
5520
6627
2819

4776
1103
3523
3588
6149
4018
1723
3324

11150
1707
13525
8213
2115

1948
9407
11624
12246
13241
7043

3025
2063
2533
5294
1735
5824
2922
1040
4752
6320
4472
5532
5041

5642
6205
11345
9931
2197
9651
6873

16801
1179
10958
13260

4806
1169
3454
5784
3091
5289
2835
1945
4995
2012
3479
6390
1073
5500

3531
13321
15104
7899
6287

27261
4225

3104
3965
1952
6493
6428
6560
2107
8364
6541
5709

4137
6331
4564
6203
2540
6225
3827
5882
3418
2746
6495
2909
1959
2494

1023
5984
1720
3188
6562
6538
2771
6244
1907
5438
4087

1788
6484
3614
7220
1555
2074
7860
6665
2814
1285
3140

2610
4711
1414
2611
1544
7094
5717

4738
6092
5271
1795
3592
1606
6309
4606
1354
3735
6498
5722
1048

7759
5334
4561
2429
15468

3489
8962
9009
8949
9558
3251
4945
2435

9471
19225
5466

1866
1611
1755
5344
6266
5702
1343
2770
6189
4469
1904
3896
1310
4909

24923
18003

14439
15042
14350
15488

3595
1976
1704
4463
5015
1484
3441
6461
3157
7163
1467
6890

5114
2338
1229
6747
6572
2729
5368
5234
6391
3476
4258

5163
4280
4165
1931
2772
3169
1887
4250
5460
5836
2477
2074
4638
4139
3204

19251
1614
11101
4036

3734
1477
13557
11678
9239
3743

3439
3959
7006
6420
7061
1813
4983
9419
3415

4075
8560
11281
5341

9383
14432
8873
8749

4262
1078
4405
5033
4781
5649
3659
3554
4879
5744
6101
2207
4144
3892

7208
11645
25286

4647
2767
4968
9196
6695
1732
5918
5934

7804
1097
8520
4513
8217
10678
1977
3678

11457
11769
12118
8118
8778
7656
7419

6814
5716
2112
4511
4826
1274
8088
6427
1906
8193

6796
1284
4977
5446
3087
6057
5189
5946
3621
1966
2078
1367

1423
1634
5851
5565
2436
5611
7167
6055
4745
3762
4920
7141

4514
18029

2173
7851
13687

7949
7418
7395
7837
11702
3934
7268

4418
6659
1116
2260
2673
3066
6605
2151
6445
4091
5630
6108
2065

34083

20266
26662

1107
3659
5578
3698
6529
1530
5096
6756
4420
5647
6321
5952

8199
4504
6056
9281
4129
4489
1301
5419
7976

2418
4557
4607
5361
3364
2998
1216
5563
4864
5017
4026
3729
4164
5482
1893

10335

3749
29027

12334
15815
14747
8990
12054

39307

9347

1924
9058
14219

4200
4950
6751
2879
4412
6649
1453
1175
3380
6612
3828
2224
4101

5166
2143
7193
1109
5859
3587
7319
3578
6272
4546
4928
4686

6162
28361

4756
6015
4766
5722
4379
3490
5431
1526
1948
5237
5531
5395
4601
5844
4016

27000
15558

7099
16480
6533
18750

11523
21417

5633
4294
2149
5611
2006
3871
3215
6970
3457
1546
6646
3536

2994
4450
3218
5868
5097
3030
5412
1989
6882
5868
5471
5722
5620

4077
7320
6705
1180
2240
7895
6841
1830
3428
2364
4641

2115
5373
4997
5593
1120
1603
5843
6059
4762
3509
3427
3718
3790
5281

3830
1503
3585
2638
2645
1007
4034
5357
3322
2172
6370
5275
1648
3700

6642
5243
13395
2913
12697

10054
5070
16403
5567
16260

25612
12129
5607

4096
2849
6717
6832
8067
7566
5627
1761
3414
3261

8681
2629
4786
7807
8511
2419
2637
6374
7707
1199

1335
6134
4672
5644
5746
8095
3526
3243

2802
1970
8067
3467
3186
4981
2459
8414
5350
2343

4051
4180
6227
1401
6469
3463
7297
2570
6420
4883
5563
2934

1785
4270
3186
4012
8204
4087
7291
6408
8390

3351
4368
2956
5319
1735
1665
2544
5050
4567
4129
3288
3057
4358
1061
4567

5567
4350
3055
1681
4082
1849
5689
1995
5573
3214
1693
3678
4958
2775
1385

15216
5215
11727

12555
12648
8124
5154
7667

10520
6081
16400
3448
6408

68455

26218

11917
4452
14142
8815
13475

4430
8657
2661
7283
5656

13776
4264
15529
16476

6032
10966
3499
6399
3107
7287
4748

1118
2057
2205
4721
4949
7969
5709
4699
4111
5100
1716

5760
4313
4368
3987
6289
3042
6007
5799
4406
4309
5816
5109
1109
2257

6186
3812
5595
4236
6718
3194
4178
1152
5631
3070
5402
2471
4489

6235
1040
2898
4618
1528
2394
6739
3492
4651
1458
2159
5166
3760

4421
5360
3586
5219
1191
3315
3087
6239
5340
6375
3885
6142
5395
1325

5908
3428
1580
8854
7674
6783
3143

68497

3036
8215
2179
6773
8316
6011
6037
5670
7097

7830
6209
1223
1431
1020
4133
6997
7137
4744
2231
4664

1447
2708
5687
3958
2020
1440
4154
1099
2180
1350
2373
4713
4490
4826
4132

4519
2370
4404
2085
5084
3342
1952
4132
5152
3370
2958
6152
6281

8688
5261
14869
7408
1789

5319
6704
1173
2404
4081
5783
2538
2725
5682
5151
1016
4692

15712
2371
15487
7088
7550

2036
6286
1362
4833
3897
4488
7093
2114
4553
4644
2014

7265
4039
4651
6351
3695
6958
6388
5849
4218
1095
6862
5034

13093
10728
1093
6368
9357

9257

6583
9137
13032
14163

6674
6220
9299
7534
2674
3144
3926
7519
8135

7207
8978
8371
4569
3486
1132
9219
3406
8054

3298
1198
2238
4091
6469
3444
2982
4702
3283
3008
1585
2615
5732
1548

3857
4772
5318
3561
5852
5463
6379
4695
4863
5184
3930
3871
6221
5660

4785
8879
2905
11710
4284
7761
10781

13650
19208
2344

8569
3740
6560
4918
8880
8863
7939
4336
7011

2667
1542
2663
5613
3498
5582
2221
3450
1197
1689
2995
5470
2690
3276
4921

3855
7774
1732
2700
4298
9114
8771
3158

6031
3440
5887
1245
3021
5776
1208
1994
2411
4057
2959
1907
1619
2028
3623

9806
3996
5730
10168
1726
7068

5828
9183
7422
5496
1545
2606
7731
3582
8998

4087
5317
6045
4977
3043
6360
3730
2012
4994
7160
6253";
            string[] caloryLists = input.Split("\r\n\r\n");

            int highestCalorySum = int.MinValue;
            int secondhighestCalorySum = int.MinValue;
            int thirdhighestCalorySum = int.MinValue;

            foreach (string caloryList in caloryLists)
            {
                int calorySum = 0;
                string[] calories = caloryList.Split("\r\n");

                foreach (string calory in calories)
                {
                    int caloryValue = int.Parse(calory);
                    calorySum += caloryValue;
                }

                if (calorySum > highestCalorySum)
                {
                    thirdhighestCalorySum = secondhighestCalorySum;
                    secondhighestCalorySum = highestCalorySum;
                    highestCalorySum = calorySum;
                }
                else if (calorySum > secondhighestCalorySum)
                {
                    thirdhighestCalorySum = secondhighestCalorySum;
                    secondhighestCalorySum = calorySum;
                }
                else if (calorySum > thirdhighestCalorySum)
                {
                    thirdhighestCalorySum = calorySum;
                }
            }

            Console.WriteLine(highestCalorySum + secondhighestCalorySum + thirdhighestCalorySum);
        }


    }
}